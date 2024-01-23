import { Component, OnInit } from '@angular/core';
import { NgbDateParserFormatter, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { DefaultOptEnum, DocumentoEnum } from 'src/app/models/facturacion.model';
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

@Component({
  selector: 'app-crear-factura',
  templateUrl: './crear-factura.component.html',
  styleUrls: ['./crear-factura.component.scss']
})
export class CrearFacturaComponent implements OnInit {

  facturaCollapsed: boolean = false;
  detalleFacturaCollapsed: boolean = false;

  tipoDocumento: string = '';

  detalleFacturaObs: Observable<any[]>;

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
    { field: '', header: 'Código producto' },
    { field: '', header: 'Descripción' },
    { field: '', header: 'Cantidad' },
    { field: '', header: 'Valor' },
    { field: '', header: '% Descuento' },
    { field: '', header: 'Sub total' },
    { field: '', header: '% Impuesto' },
    { field: '', header: 'Valor impuesto' },
    { field: '', header: 'Total' }
  ];

  constructor(
    private storageService: StorageService,
    private generalService: GeneralService,
    private cargueCombosService: CargueCombosService,
    private detalleEmpresaService: DetalleEmpresaService,
    private modalService: NgbModal,
    private router: Router
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
    this.cargarListaCombox();
    this.initData();
    this.initAction();
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
      facturaId: 0
    };
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
      factDescGlobal: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
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
      factFechaInicio: [ { value: '', disabled: !this.sectorSaludOpt }, [] ],
      factFechaFinal: [ { value: '', disabled: !this.sectorSaludOpt }, [] ],
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
      factPoliza: [ { value: '', disabled: false }, [] ],
      factPorcIva: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factRecepcion: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factRemision: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factSubtotal: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factSucursal: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factTotalIva: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factTotalReteIca: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factTrm: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      factValAnticipo: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factValor: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factValorDescuento: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factValTotRetefuente: [ { value: '', disabled: false }, [
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
      factEmpresaId: [ { value: null, disabled: false }, [
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
      factListaPreciosId: [ { value: '0', disabled: false }, [
          Validators.required
        ]
      ],
      factNotaDebitoId: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factNotaCreditoId: [ { value: null, disabled: false }, [
          Validators.required
        ]
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

  initFormFact(): void {
    const formControls: { [key: string]: any } = {
      factSubtotal: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ],
      factDescGlobal: [ { value: null, disabled: false }, [
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
      factValor: [ { value: null, disabled: false }, [
          Validators.required
        ]
      ]
    }

    this.totalFacturaFormGroup = this.fbFact.group(formControls);
  }

  guardarCabecera(): void {
    if (this.encabezadoFormGroup.invalid) {
      this.encabezadoFormGroup.markAllAsTouched();
      return;
    }
  }

  formatterResult = (cliente: IClienteEmpresa) => {
    return `${cliente.clieNit} - ${cliente.cliePrimerNom} ${cliente.clieSegundoNom} ${cliente.clieApellidos}`;
  }
  formatterInput = (cliente: IClienteEmpresa) => {
    this.clienteEmpresa = cliente;
    return `${cliente.clieNit} - ${cliente.cliePrimerNom} ${cliente.clieSegundoNom} ${cliente.clieApellidos}`;
  }

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
