import { Component, OnInit } from '@angular/core';
import { NgbDate, NgbDateAdapter, NgbDateParserFormatter, NgbInputDatepickerConfig, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { DefaultOptEnum, DocumentoEnum, ICreacionFactura, IDetalleFactura, IFactura } from 'src/app/models/facturacion.model';
import { CrearCabeceraFacturaComponent } from '../../modals/crear-cabecera-factura/crear-cabecera-factura.component';
import { Observable, OperatorFunction } from 'rxjs';
import { DocumentoOpcionesComponent } from '../../modals/documento-opciones/documento-opciones.component';
import { Router } from '@angular/router';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IListCombo } from 'src/app/models/general.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { TipoListEnum } from 'src/app/models/enums-aplicacion.model';
import { AgregarProductoComponent } from '../../modals/agregar-producto/agregar-producto.component';
import { CustomDateParserFormatter } from 'src/app/shared/datepicker/custom-date-parser-formatter';
import { ICliente } from 'src/app/models/cliente.model';
import { debounceTime, distinctUntilChanged, filter, map } from 'rxjs/operators';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { IClienteEmpresa } from 'src/app/models/cliente-empresa.model';
import { FacturacionService } from 'src/app/services/facturacion-service/facturacion.service';
import { ListaPrecioService } from 'src/app/services/lista-precio-service/lista-precio.service';
import { PercentInputDirective } from 'src/app/shared/percent-input-directive/percent-input.directive';
import * as moment from 'moment';

@Component({
  selector: 'app-crear-factura',
  templateUrl: './crear-factura.component.html',
  styleUrls: ['./crear-factura.component.scss']
})
export class CrearFacturaComponent implements OnInit {

  facturaCollapsed: boolean = false;
  detalleFacturaCollapsed: boolean = false;

  tipoDocumento: string = '';

  verDetalleFactura: boolean = false;

  facturaId: number;

  detalleFacturaObs: Observable<any[]>;
  detalleFactura: IDetalleFactura[] = [];

  listaPrecioId: number;

  encabezadoFormGroup: FormGroup;
  fb = new FormBuilder();

  totalFacturaFormGroup: FormGroup;
  fbFact = new FormBuilder();

  dataEmpresa: IEmpresa;
  clienteEmpresa: IClienteEmpresa;

  listaClaseFactura: IListCombo[] = [];
  listaCobertura: IListCombo[] = [];
  listaCondicionVenta: IListCombo[] = [];
  listaEstadoDian: IListCombo[] = [];
  listaFormaPago: IListCombo[] = [];
  listaFormatoImpresion: IListCombo[] = [];
  listaMoneda: IListCombo[] = [];
  listaSaludTipo: IListCombo[] = [];
  listaTipoDescuento: IListCombo[] = [];
  listaTipoDocElectr: IListCombo[] = [];
  listaPreciosLista: IListCombo[] = [];

  listaClientes: any[] = [];

  colsDetalleFactura: any[] = [
    { field: 'detaFactCodigo', header: 'Código producto' },
    { field: 'detaDescripcion', header: 'Descripción' },
    { field: 'detaCantidad', header: 'Cantidad' },
    { field: 'detaValorUnitario', currency: true, header: 'Valor' },
    { field: 'detaPorDescuento', header: '% Descuento' },
    { field: 'subtotal', currency: true, header: 'Sub total' },
    { field: 'detaValor', currency: true, header: 'Total' }
  ];

  maskDateSlash = [/\d/, /\d/, '/', /\d/, /\d/, '/', /\d/, /\d/, /\d/, /\d/];

  constructor(
    private storageService: StorageService,
    private generalService: GeneralService,
    private cargueCombosService: CargueCombosService,
    private detalleEmpresaService: DetalleEmpresaService,
    private facturacionService: FacturacionService,
    private listaPrecioService: ListaPrecioService,
    private modalService: NgbModal,
    private router: Router,
    private dateAdapter: NgbDateAdapter<any>
  ) { }

  ngOnInit(): void {
    // this.iniciarEncabezado();
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.iniciarDocumentoOpcion();
    this.init();
    // this.initForm();
    // this.cargarListaCombox();
  }

  get listaDocumento() {
    return DocumentoEnum;
  }

  init(): void {
  }

  iniciarDocumentoOpcion(): void {
    const opcionModal = this.modalService.open(DocumentoOpcionesComponent, {
      size: 'sm',
      backdrop: 'static',
      keyboard: false,
      centered: true
    });

    opcionModal.result.then((response: string) => {
      if (response) {
        this.tipoDocumento = response;
        this.iniciarFacturacion(response);
      } else {
        this.router.navigate(['/']);
      }
    });
  }

  iniciarEncabezado(): void {
    const modalEncabezado = this.modalService.open(
        CrearCabeceraFacturaComponent, {
          backdrop: 'static',
          keyboard: false,
          centered: true,
          size: 'xl'
      }
    );
  }

  iniciarFacturacion(tipoDocumento: string): void {
    this.initForm();
    this.initFormFact();
    this.cargarListaCombox();
    this.initData();
    this.initAction();
    this.actionControls();
  }

  agregarProducto(): void {
    const modalProducto = this.modalService.open(
      AgregarProductoComponent, {
        backdrop: 'static',
        centered: true,
        size: 'xl'
      }
    );

    modalProducto.componentInstance.facturaData = {
      empresaId: this.dataEmpresa.id,
      listaPreciosId: this.listaPrecioId,
      facturaId: 0
    };

    modalProducto.result.then((result) => {
      if (result) {

        this.detalleFactura.push(result);
        this.detalleFactura.map((item) => {
          const totalProd = item.detaCantidad * item.detaValorUnitario;
          const descuento = (totalProd * item.detaPorDescuento) / 100;
          const totalDesc = totalProd - descuento;
          item.subtotal = totalDesc;
        });

        this.detalleFactura.map((item) => {

        });

        const subtotal = this.detalleFactura.reduce((acumulado, item) => acumulado + item.subtotal, 0);
        const total = this.detalleFactura.reduce((acumulado, item) => acumulado + item.detaValor, 0);

        this.totalFacturaFormGroup.get('factSubtotal').setValue(subtotal);
        this.totalFacturaFormGroup.get('factValor').setValue(total);
      }
    });

  }

  cargarListaCombox(): void {
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.CLASE_FACTURA).subscribe({
      next: (response) => this.listaClaseFactura = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.COBERTURA).subscribe({
      next: (response) => this.listaCobertura = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.CONDICION_VENTA).subscribe({
      next: (response) => this.listaCondicionVenta = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.ESTADO_DIAN_FACTURA).subscribe({
      next: (response) => this.listaEstadoDian = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.FORMA_PAGO).subscribe({
      next: (response) => this.listaFormaPago = response
    });

    this.cargueCombosService.obtenerListaFormatosImpresionEmpresa(this.dataEmpresa.id)
    .subscribe({
      next: (response) => {
        this.listaFormatoImpresion = response;
      }
    });

    this.listaPrecioService.obtenerListaPrecioPorEmpresa(this.dataEmpresa.id)
    .pipe(
      map((response) =>
        response?.map((item) => ({
          valor: item.id,
          nombre: item.liprNombre
        })) as IListCombo[])
    )
    .subscribe({
      next: (response) => {
        this.listaPreciosLista = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.MONEDA).subscribe({
      next: (response) => {
        this.listaMoneda = response;

        if (response.length > 0) {

          const idx = response.find(item => {
            const normalize = (str: string) => str.replace(/\s+/g, '').toLowerCase();
            return normalize(item.codigo) === normalize(DefaultOptEnum.MONEDA);
          });

          this.encabezadoFormGroup.get('factMonedaId').setValue(idx?.valor);
        }
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.FACT_SALUD_TIPO).subscribe({
      next: (response) => this.listaSaludTipo = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_DESCUENTO).subscribe({
      next: (response) => this.listaTipoDescuento = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_DOC_ELECTR).subscribe({
      next: (response) => {
        this.listaTipoDocElectr = response;

        if (response.length > 0) {

          const idx = response.find(item => {
            const normalize = (str: string) => str.replace(/\s+/g, '').toLowerCase();
            return normalize(item.nombre) === normalize(DefaultOptEnum.TIPO_DOC_ELECTRONICO);
          });

          this.encabezadoFormGroup.get('factTipoDocElectrId').setValue(idx?.valor);
        }
      }
    });

  }

  actionControls(): void {
    this.totalFacturaFormGroup.get('factSubtotal').valueChanges.subscribe({
      next: (value) => {
        if (value) {

        }
      }
    });

    this.totalFacturaFormGroup.get('factDescGlobal').valueChanges.subscribe({
      next: (value) => {
        let total = 0;
        if (value) {
          const valorSub = this.totalFacturaFormGroup.get('factSubtotal').value;
          const valorTotal = this.detalleFactura.reduce((acumulado, item) => acumulado + item.detaValor, 0);
          const valDescuento = ((valorSub * value) / 100);
          this.totalFacturaFormGroup.get('factValorDescuento').setValue(valDescuento, { emitEvent: false });
          total = valorTotal - valDescuento;

        } else {
          total = this.detalleFactura.reduce((acumulado, item) => acumulado + item.detaValor, 0);
          this.totalFacturaFormGroup.get('factValorDescuento').setValue('', { emitEvent: false });
        }

        this.totalFacturaFormGroup.get('factValor').setValue(total);
      }
    });

    this.totalFacturaFormGroup.get('factValorDescuento').valueChanges.subscribe({
      next: (value) => {
        let total = 0;
        if (value) {
          const valorTotal = this.detalleFactura.reduce((acumulado, item) => acumulado + item.detaValor, 0);
          const valorSub = this.totalFacturaFormGroup.get('factSubtotal').value;
          const valor = (+value * 100) / +valorSub;
          this.totalFacturaFormGroup.get('factDescGlobal').setValue(valor?.toFixed(2), { emitEvent: false });
          total = +valorTotal - +value;
        } else {
          total = this.detalleFactura.reduce((acumulado, item) => acumulado + item.detaValor, 0);
          this.totalFacturaFormGroup.get('factDescGlobal').setValue('', { emitEvent: false });
        }

        this.totalFacturaFormGroup.get('factValor').setValue(total);
      }
    })

    this.totalFacturaFormGroup.get('factPorcIva').valueChanges.subscribe({
      next: (value) => {
        this.totalFacturaFormGroup.get('factDescGlobal').updateValueAndValidity();
        if (value) {
          const descuento = this.totalFacturaFormGroup.get('factValorDescuento').value;
          const totalValor = this.totalFacturaFormGroup.get('factValor').value;
          const subtotal = this.detalleFactura.reduce((acumulado, item) => acumulado + item.subtotal, 0);
          const sumtotal = subtotal - descuento;
          const valor = (+sumtotal * +value) / 100;
          const total = totalValor + valor;

          this.totalFacturaFormGroup.get('factTotalIva').setValue(valor, { emitEvent: false });
          this.totalFacturaFormGroup.get('factValor').setValue(total);
        } else {
          this.totalFacturaFormGroup.get('factTotalIva').setValue('', { emitEvent: false });
        }
      }
    })

    this.totalFacturaFormGroup.get('factTotalIva').valueChanges.subscribe({
      next: (value) => {
        this.totalFacturaFormGroup.get('factDescGlobal').updateValueAndValidity();
        if (value) {
          const descuento = this.totalFacturaFormGroup.get('factValorDescuento').value;
          const totalValor = this.totalFacturaFormGroup.get('factValor').value;
          const subtotal = this.detalleFactura.reduce((acumulado, item) => acumulado + item.subtotal, 0);
          const sumtotal = subtotal - descuento;
          const valor = (+value * 100) / +sumtotal;
          const total = +totalValor + +value;

          this.totalFacturaFormGroup.get('factPorcIva').setValue(valor?.toFixed(2), { emitEvent: false });
          this.totalFacturaFormGroup.get('factValor').setValue(total);
        } else {
          this.totalFacturaFormGroup.get('factPorcIva').setValue('', { emitEvent: false });
        }
      }
    })

    this.totalFacturaFormGroup.get('factTotalReteIca').valueChanges.subscribe({
      next: (value) => {
        this.totalFacturaFormGroup.get('factDescGlobal').updateValueAndValidity();
        // this.totalFacturaFormGroup.get('detaValRf').updateValueAndValidity();
        if (value) {
          const valTotal = this.totalFacturaFormGroup.get('factValor').value;
          const total = valTotal - value;

          this.totalFacturaFormGroup.get('factValor').setValue(total);
        }
      }
    })

    this.totalFacturaFormGroup.get('factListaPreciosId').valueChanges.subscribe({
      next: (value) => {
        if (value) {
          this.listaPrecioId = value;
        }
      }
    })

    // this.totalFacturaFormGroup.get('factValTotRetefuente').valueChanges.subscribe({
    //   next: (value) => {
    //     this.totalFacturaFormGroup.get('factDescGlobal').updateValueAndValidity();
    //     if (value) {
    //       const controlTotal = this.totalFacturaFormGroup.get('detaValor').value;
    //       const valor = (+value * 100) / +controlTotal;
    //       this.totalFacturaFormGroup.get('detaIva').updateValueAndValidity();
    //       const valTotalIva = this.totalFacturaFormGroup.get('detaValor').value;
    //       const total = valTotalIva + value;

    //       this.totalFacturaFormGroup.get('detaPorcCrf').setValue(valor, { emitEvent: false });
    //       this.totalFacturaFormGroup.get('detaValor').setValue(total);
    //     } else {
    //       this.totalFacturaFormGroup.get('detaIva').updateValueAndValidity();
    //       this.totalFacturaFormGroup.get('detaPorcCrf').setValue('', { emitEvent: false });
    //     }
    //   }
    // })

    // this.totalFacturaFormGroup.get('factDescGlobal').valueChanges.subscribe({
    //   next: (value) => {
    //     if (value) {

    //     }
    //   }
    // })
  }

  initData(): void {
    this.detalleEmpresaService.obtenerInformacionClientesEmpresaId(this.dataEmpresa.id).subscribe({
      next: (result) => {
        this.listaClientes = result;
      }
    });
  }

  initAction(): void {
    this.encabezadoFormGroup.get('factMonedaId').valueChanges.subscribe({
      next: (value) => {
        const idx = this.listaMoneda.find(item => {
          const normalize = (str: string) => str.replace(/\s+/g, '').toLowerCase();
          return normalize(item.codigo) === normalize(DefaultOptEnum.MONEDA);
        });

        idx.valor === +value ? this.encabezadoFormGroup.get('factTrm').disable() : this.encabezadoFormGroup.get('factTrm').enable();
      }
    });
  }

  get sectorSaludOpt()  {
    return this.tipoDocumento === DocumentoEnum.SECTOR_SALUD;
  }


  initForm(): void {
    const formControls: { [key: string]: any } = {
      factFechaTrm: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factCompartidos: [ { value: null, disabled: false }, [] ],
      factContador: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factContrato: [ { value: '', disabled: false }, [] ],
      factCopago: [ { value: null, disabled: false }, [] ],
      factCufe: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factCuotaRecupera: [ { value: null, disabled: false }, [] ],
      factDespacho: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factEstadoOperacion: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factFecha: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factFechaVence: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factFechaInicio: [ { value: null, disabled: !this.sectorSaludOpt }, [] ],
      factFechaFinal: [ { value: null, disabled: !this.sectorSaludOpt }, [] ],
      factModalidadPago: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factModeradora: [ { value: null, disabled: false }, [] ],
      factNumero: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factObservaciones: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factOperador: [ { value: '', disabled: !this.sectorSaludOpt }, [
          Validators.required
        ]
      ],
      factOrden: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factPoliza: [ { value: null, disabled: false }, [] ],
      factRecepcion: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factRemision: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factSucursal: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factTrm: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factVendedor: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factClaseFacturaId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factCoberturaId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factCondicionVentaId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factEstadoDianId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factFormaPagoId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factFormatoImpresionId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factMonedaId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factSaludTipoId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factTipoDescuentoId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factTipoDocElectrId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factListaPreciosId: [ { value: null, disabled: false }, []
      ],
      factNotaDebitoId: [ { value: null, disabled: false }, []
      ],
      factNotaCreditoId: [ { value: null, disabled: false }, []
      ],
      factClienteId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
    }

    this.encabezadoFormGroup = this.fb.group(formControls);
  }


  get factFechaTrmErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factFechaTrm') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factContadorErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factContador') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factCufeErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factCufe') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factDespachoErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factDespacho') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factEstadoOperacionErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factEstadoOperacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factFechaErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factFecha') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factFechaVenceErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factFechaVence') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factNumeroErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factNumero') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factObservacionesErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factObservaciones') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factOperadorErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factOperador') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factOrdenErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factOrden') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factRecepcionErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factRecepcion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factRemisionErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factRemision') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factSucursalErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factSucursal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factTrmErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factTrm') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factVendedorErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factVendedor') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factClaseFacturaIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factClaseFacturaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factCoberturaIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factCoberturaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factCondicionVentaIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factCondicionVentaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factModalidadPagoErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factModalidadPago') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factEstadoDianIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factEstadoDianId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factFormaPagoIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factFormaPagoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factFormatoImpresionIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factFormatoImpresionId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factMonedaIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factMonedaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factSaludTipoIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factSaludTipoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factTipoDescuentoIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factTipoDescuentoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factTipoDocElectrIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factTipoDocElectrId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factListaPreciosIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factListaPreciosId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factClienteIdErrorMensaje(): string {
    const form: AbstractControl = this.encabezadoFormGroup.get('factClienteId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  initFormFact(): void {
    const formControls: { [key: string]: any } = {
      factSubtotal: [ { value: null, disabled: true }, [
          Validators.required
        ]
      ],
      factDescGlobal: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factValorDescuento: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factPorcIva: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factTotalIva: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factValAnticipo: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factTotalReteIca: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factValTotRetefuente: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factValor: [ { value: null, disabled: true }, [
          Validators.required
        ]
      ]
    }

    this.totalFacturaFormGroup = this.fbFact.group(formControls);
  }

  get factSubtotalErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factSubtotal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factDescGlobalErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factDescGlobal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factValorDescuentoErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factValorDescuento') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factPorcIvaErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factPorcIva') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factTotalIvaErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factTotalIva') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factValAnticipoErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factValAnticipo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factTotalReteIcaErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factTotalReteIca') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factValTotRetefuenteErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factValTotRetefuente') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get factValorErrorMensaje(): string {
    const form: AbstractControl = this.totalFacturaFormGroup.get('factValor') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  guardarCabecera(): void {

    if (this.encabezadoFormGroup.invalid) {
      this.encabezadoFormGroup.markAllAsTouched();
      return;
    }

    const formData = this.encabezadoFormGroup.getRawValue();

    const body: IFactura = {
      estado: 1,
      fechaCreacion: null,
      fechaModificacion: null,
      factCuotaRecupera: formData.factCuotaRecupera,
      factOperador: formData.factOperador,
      factFechaInicio: formData.factFechaInicio ? moment(formData.factFechaInicio, 'DD/MM/YYYY').toDate() : null,
      factFechaFinal: formData.factFechaFinal ? moment(formData.factFechaFinal, 'DD/MM/YYYY').toDate() : null,
      factNumero: formData.factNumero,
      factContador: formData.factContador,
      factCompartidos: formData.factCompartidos,
      factCufe: formData.factCufe,
      factContrato: formData.factContrato,
      factDespacho: formData.factDespacho,
      factEstadoOperacion: formData.factEstadoOperacion,
      factFechaTrm: moment(formData.factFechaTrm, 'DD/MM/YYYY').toDate(),
      factCopago: formData.factCopago,
      factDescGlobal: 0,
      factFecha: moment(formData.factFecha, 'DD/MM/YYYY').toDate(),
      factFechaVence: moment(formData.factFechaVence, 'DD/MM/YYYY').toDate(),
      factModalidadPago: formData.factModalidadPago,
      factModeradora: formData.factModeradora,
      factObservaciones: formData.factObservaciones,
      factOrden: formData.factOrden,
      factPoliza: formData.factPoliza,
      factPorcIva: '0',
      factRecepcion: formData.factRecepcion,
      factRemision: formData.factRemision,
      factSubtotal: 0,
      factSucursal: formData.factSucursal,
      factTotalIva: 0,
      factTotalReteIca: '0',
      factTrm: formData.factTrm,
      factValAnticipo: 0,
      factValor: 0,
      factValorDescuento: 0,
      factValTotRetefuente: '0',
      factVendedor: formData.factVendedor,
      factClaseFacturaId: formData.factClaseFacturaId,
      factCoberturaId: formData.factCoberturaId,
      factCondicionVentaId: formData.factCondicionVentaId,
      factEmpresaId: this.dataEmpresa.id,
      factEstadoDianId: formData.factEstadoDianId,
      factFormaPagoId: formData.factFormaPagoId,
      factFormatoImpresionId: formData.factFormatoImpresionId,
      factMonedaId: formData.factMonedaId,
      factSaludTipoId: formData.factSaludTipoId,
      factTipoDescuentoId: formData.factTipoDescuentoId,
      factTipoDocElectrId: formData.factTipoDocElectrId,
      factListaPreciosId: formData.factListaPreciosId,
      factNotaDebitoId: formData.factNotaDebitoId,
      factNotaCreditoId: formData.factNotaCreditoId,
      factClienteId: this.clienteEmpresa.id
    }

    Object.keys(body).forEach(key => {
      if (body[key] === null) {
        delete body[key];
      }
    });

    this.listaPrecioId = formData.factListaPreciosId;

    this.facturacionService.crearFactura(body).subscribe({
      next: (response) => {
        console.log(response);
        this.verDetalleFactura = true;
      }
    });

  }

  onDateSelect(date: NgbDate, key: string): void {
    const formControl: any = {};
    formControl[key] = this.dateAdapter.toModel(date);
    formControl[key] = `${this.padNumber(date.day)}/${this.padNumber(date.month)}/${date.year}`;
    this.encabezadoFormGroup.patchValue(formControl);
  }

  formatterResult = (cliente: IClienteEmpresa) => {
    return `${cliente.clieNit} - ${cliente.cliePrimerNom} ${cliente.clieSegundoNom} ${cliente.clieApellidos}`;
  }
  formatterInput = (cliente: IClienteEmpresa) => {
    this.clienteEmpresa = cliente;
    return `${cliente.clieNit} - ${cliente.cliePrimerNom} ${cliente.clieSegundoNom} ${cliente.clieApellidos}`;
  }

  padNumber = (value: number) => {
    if (typeof value === 'number') {
      return `0${value}`.slice(-2);
    } else {
      return '';
    }
  }

  // formatCurrency(value: number): string {
  //   // Formatea el valor como moneda con un separador de miles
  //   // const formattedValue = this.ngxMaskPipe.transform(value, 'currency', {
  //   //   allowNegative: false,
  //   //   thousandsSeparator: ',',
  //   //   prefix: '$',
  //   //   decimalSeparator: '.',
  //   //   align: 'left',
  //   //   precision: 2
  //   // });
  //   // return formattedValue;
  // }

  search: OperatorFunction<string, readonly { cliePrimerNom; clieSegundoNom, clieApellidos, clieNit }[]> = (text$: Observable<string>) =>
		text$.pipe(
			debounceTime(200),
			distinctUntilChanged(),
			filter((term) => term.length >= 2),
			map((term) => this.listaClientes?.filter((cliente) =>
        new RegExp(term, 'mi').test(cliente.cliePrimerNom) ||
        new RegExp(term, 'mi').test(cliente.clieSegundoNom) ||
        new RegExp(term, 'mi').test(cliente.clieApellidos) ||
        new RegExp(term, 'mi').test(cliente.clieNit)
      ).slice(0, 10)),
		);

    onBlurFormat() {
      const control = this.encabezadoFormGroup.get('factClienteId');
      if (!control.value) {
        control.setValue('');
        this.clienteEmpresa = null;
      }
    }

}
