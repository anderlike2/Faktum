import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { map } from 'rxjs/operators';
import { ICentroCostos } from 'src/app/models/centro-costos.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IProducto, tipoConceptoEnum } from 'src/app/models/producto.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { CentroCostosService } from 'src/app/services/centro-costos-service/centro-costos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ProductoService } from 'src/app/services/producto-service/producto.service';

@Component({
  selector: 'app-crear-producto',
  templateUrl: './crear-producto.component.html',
  styleUrls: ['./crear-producto.component.scss']
})
export class CrearProductoComponent implements OnInit {

  @Input() empresaID: number;

  productoFormGroup: FormGroup;
  fb = new FormBuilder();

  listaListPrecios: IListCombo[] = [];
  listaCentroCostos: IListCombo[] = [];
  listaCums: IListCombo[] = [];
  listaCups: IListCombo[] = [];
  listaIums: IListCombo[] = [];
  listaTipoCups: IListCombo[] = [];
  listaTipoImpuesto: IListCombo[] = [];
  listaTipoRips: IListCombo[] = [];
  listaUnidad: IListCombo[] = [];
  listaOtroProducto: IListCombo[] = [];

  listaOpcionesMap: { [key: string]: () => void } = {
    [tipoConceptoEnum.CUPS]: this.seleccionCups.bind(this),
    [tipoConceptoEnum.MEDICAMENTOS]: this.seleccionMedicamentos.bind(this),
    [tipoConceptoEnum.OTROS_PRODUCTOS]: this.seleccionOtroProducto.bind(this)
  }

  get tipoConcepto() {
    return tipoConceptoEnum;
  }

  constructor(
    private productoService: ProductoService,
    private cargueCombosService: CargueCombosService,
    private centroCostosService: CentroCostosService,
    private generalService: GeneralService,
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarListaCombox();
    this.iniConcepto();
  }

  cargarListaCombox(): void {

    this.centroCostosService.obtenerCentroCostosPorEmpresaId(this.empresaID)
    .pipe(
      map((response) =>
        response.map((item) => ({
          valor: item.id,
          nombre: item.ccosNombre,
          codigo: item.ccosCodigo
        })) as IListCombo[]
      )
    )
    .subscribe({
      next: (response) => this.listaCentroCostos = response
    });

    this.cargueCombosService.obtenerListaTablaImpuestos().subscribe({
      next: (response) => this.listaTipoImpuesto = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_ARCHIVO_RIPS).subscribe({
      next: (response) => this.listaTipoRips = response
    });

    this.cargueCombosService.obtenerListaUnidadesEmpresa(this.empresaID).subscribe({
      next: (response) => this.listaUnidad = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_CUPS).subscribe({
      next: (response) => this.listaTipoCups = response
    });

  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      prodNombreFactura: [ { value: '', disabled: false }, [
            Validators.required
          ]
        ],
      prodNombreTecnico: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodCodigo: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodUnidadHomologa: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodMarca: [ { value: '', disabled: false }, [
        Validators.required
        ]
      ],
      prodModelo: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodValor: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodPorcIva: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodCentroCostoId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodPorcReteFuente: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodCumId: [ { value: null, disabled: true }, [
          Validators.required
        ]
      ],
      prodCupId: [ { value: null, disabled: true }, [
          Validators.required
        ]
      ],
      prodIumId: [ { value: null, disabled: true }, [
          Validators.required
        ]
      ],
      prodTipoCupId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodTipoImpuestoId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodTipoRipsId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodUnidadId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodOtroProductoId: [ { value: null, disabled: true }, [
          Validators.required
        ]
      ],
      concepto: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ]
    };

    this.productoFormGroup = this.fb.group(formControls);
  }

  get prodNombreFacturaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodNombreFactura') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodNombreTecnicoErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodNombreTecnico') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodCodigoErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodUnidadHomologaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodUnidadHomologa') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodMarcaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodMarca') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodModeloErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodModelo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodValorErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodValor') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodPorcIvaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodPorcIva') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodCentroCostoIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodCentroCostoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodPorcReteFuenteErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodPorcReteFuente') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodCumIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodCumId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodCupIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodCupId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodIumIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodIumId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodTipoCupIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodTipoCupId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodTipoImpuestoIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodTipoImpuestoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodTipoRipsIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodTipoRipsId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodUnidadIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodUnidadId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get prodOtroProductoIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('prodOtroProductoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get conceptoErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('concepto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  iniConcepto(): void {
    this.productoFormGroup.get('concepto').valueChanges.subscribe({
      next: (value) => {
        const fn = this.listaOpcionesMap[value];

        if(fn) {
          fn();
        }
      }
    });
  }

  seleccionCups(): void {
    this.productoFormGroup.get('prodCupId').enable();
    this.productoFormGroup.get('prodCumId').disable();
    this.productoFormGroup.get('prodIumId').disable();
    this.productoFormGroup.get('prodOtroProductoId').disable();

    this.listaCums = [];
    this.listaCups = [];
    this.listaIums = [];
    this.listaOtroProducto = [];

    this.productoFormGroup.get('prodCupId').reset();

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.CUPS).subscribe({
      next: (response) => this.listaCups = response
    });
  }

  seleccionMedicamentos(): void {
    this.productoFormGroup.get('prodCupId').disable();
    this.productoFormGroup.get('prodCumId').enable();
    this.productoFormGroup.get('prodIumId').enable();
    this.productoFormGroup.get('prodOtroProductoId').disable();

    this.listaCums = [];
    this.listaCups = [];
    this.listaIums = [];
    this.listaOtroProducto = [];

    this.productoFormGroup.get('prodCumId').reset();
    this.productoFormGroup.get('prodIumId').reset();

    this.cargueCombosService.obtenerListaTablaCum().subscribe({
      next: (response) => this.listaCums = response
    });

    this.cargueCombosService.obtenerListaTablaIum().subscribe({
      next: (response) => this.listaIums = response
    });

  }

  seleccionOtroProducto(): void {
    this.productoFormGroup.get('prodCupId').disable();
    this.productoFormGroup.get('prodCumId').disable();
    this.productoFormGroup.get('prodIumId').disable();
    this.productoFormGroup.get('prodOtroProductoId').enable();

    this.listaCums = [];
    this.listaCups = [];
    this.listaIums = [];
    this.listaOtroProducto = [];

    this.productoFormGroup.get('prodOtroProductoId').reset();

    this.cargueCombosService.obtenerListaOtroProductoPorEmpresa(this.empresaID).subscribe({
      next: (response) => this.listaOtroProducto = response
    });
  }

  guardarProducto(): void {
    if (this.productoFormGroup.invalid) {
      this.productoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IProducto = this.productoFormGroup.value;

    dataBody.id = 0;
    dataBody.estado = 1;

    dataBody.prodEmpresaId = this.empresaID;

    this.productoService.crearProducto(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
           this.cerrarModal();
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cerrarModal() {
    this.modalRef.close();
  }

}
