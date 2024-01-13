import { AfterViewInit, Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { map } from 'rxjs/operators';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IProducto, tipoConceptoEnum } from 'src/app/models/producto.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { CentroCostosService } from 'src/app/services/centro-costos-service/centro-costos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Component({
  selector: 'app-editar-producto',
  templateUrl: './editar-producto.component.html',
  styleUrls: ['./editar-producto.component.scss']
})
export class EditarProductoComponent implements OnInit, AfterViewInit {

  productoCollapsed: boolean = false;
  edicionProducto: boolean = false;

  productoData: IProducto;

  conceptoInicial: string = '';

  productoFormGroup: FormGroup;
  fb = new FormBuilder();

  listaListPrecios: IListCombo[] = [];
  listaCentroCostos: IListCombo[] = [];
  listaCodRetencionFuente: IListCombo[] = [];
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

  desactivarConceptosMap: { [key: string]: () => void } = {
    [tipoConceptoEnum.CUPS]: () => {
      this.productoFormGroup.get('prodCumId').disable();
      this.productoFormGroup.get('prodIumId').disable();
      this.productoFormGroup.get('prodOtroProductoId').disable();
    },
    [tipoConceptoEnum.MEDICAMENTOS]: () => {
      this.productoFormGroup.get('prodCupId').disable();
      this.productoFormGroup.get('prodOtroProductoId').disable();
    },
    [tipoConceptoEnum.OTROS_PRODUCTOS]: () => {
      this.productoFormGroup.get('prodCupId').disable();
      this.productoFormGroup.get('prodCumId').disable();
      this.productoFormGroup.get('prodIumId').disable();
    }
  }

  get tipoConcepto() {
    return tipoConceptoEnum;
  }

  constructor(
    private productoService: ProductoService,
    private centroCostosService: CentroCostosService,
    private cargueCombosService: CargueCombosService,
    private sharedService: SharedService,
    private generalService: GeneralService
  ) { }

  ngAfterViewInit(): void {
    this.cargarListaCombox();
    this.iniConcepto();
  }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.sharedService.productoDataListener$.subscribe(this.obtenerProducto.bind(this));
  }

  cargarListaCombox(): void {

    this.cargueCombosService.obtenerListaReteFuente().subscribe({
      next: (response) => this.listaCodRetencionFuente = response
    });

    this.cargueCombosService.obtenerListaTablaImpuestos().subscribe({
      next: (response) => this.listaTipoImpuesto = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_ARCHIVO_RIPS).subscribe({
      next: (response) => this.listaTipoRips = response
    });


    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_CUPS).subscribe({
      next: (response) => this.listaTipoCups = response
    });

  }

  cargarComboxEmpresa(empresaId: number): void {
    this.centroCostosService.obtenerCentroCostosPorEmpresaId(empresaId)
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

    this.cargueCombosService.obtenerListaUnidadesEmpresa(empresaId).subscribe({
      next: (response) => this.listaUnidad = response
    });
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
    if (this.edicionProducto) {
      this.productoFormGroup.get('prodCupId').enable();
      this.productoFormGroup.get('prodCumId').disable();
      this.productoFormGroup.get('prodIumId').disable();
      this.productoFormGroup.get('prodOtroProductoId').disable();

      this.listaCums = [];
      this.listaCups = [];
      this.listaIums = [];
      this.listaOtroProducto = [];

      this.productoFormGroup.get('prodCupId').reset();
    }
    console.log(this.edicionProducto);

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.CUPS).subscribe({
      next: (response) => this.listaCups = response
    });
  }

  seleccionMedicamentos(): void {
    if (this.edicionProducto) {
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
    }

    this.cargueCombosService.obtenerListaTablaCum().subscribe({
      next: (response) => this.listaCums = response
    });

    this.cargueCombosService.obtenerListaTablaIum().subscribe({
      next: (response) => this.listaIums = response
    });

  }

  seleccionOtroProducto(): void {
    if (this.edicionProducto) {
      this.productoFormGroup.get('prodCupId').disable();
      this.productoFormGroup.get('prodCumId').disable();
      this.productoFormGroup.get('prodIumId').disable();
      this.productoFormGroup.get('prodOtroProductoId').enable();

      this.listaCums = [];
      this.listaCups = [];
      this.listaIums = [];
      this.listaOtroProducto = [];

      this.productoFormGroup.get('prodOtroProductoId').reset();
    }

    this.cargueCombosService.obtenerListaOtroProductoPorEmpresa(this.productoData.prodEmpresaId).subscribe({
      next: (response) => this.listaOtroProducto = response
    });
  }

  obtenerProducto(data: IProducto): void {
    this.conceptoOptsSelect(data);
    this.cargarComboxEmpresa(data?.prodEmpresaId);
    this.productoService.obtenerProductoPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.productoData = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  conceptoOptsSelect(data: IProducto): void {
    if (data?.prodCupId !== null) {
      this.productoFormGroup.get('concepto').setValue(tipoConceptoEnum.CUPS);
      if (this.conceptoInicial === '') {
        this.conceptoInicial = tipoConceptoEnum.CUPS;
      }
    } else
    if (data?.prodIumId !== null || data?.prodCumId !== null) {
      this.productoFormGroup.get('concepto').setValue(tipoConceptoEnum.MEDICAMENTOS);
      if (this.conceptoInicial === '') {
        this.conceptoInicial = tipoConceptoEnum.MEDICAMENTOS;
      }
    } else
    if (data?.prodOtroProductoId !== null) {
      this.productoFormGroup.get('concepto').setValue(tipoConceptoEnum.OTROS_PRODUCTOS);
      if (this.conceptoInicial === '') {
        this.conceptoInicial = tipoConceptoEnum.OTROS_PRODUCTOS;
      }
    }
  }

  cargarDataForm(data: IProducto): void {
    this.edicionProducto = false;
    this.productoFormGroup.get('concepto').setValue(this.conceptoInicial);
    this.productoFormGroup.disable();
    this.productoFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.productoFormGroup.enable();
    const conceptoValor = this.productoFormGroup.get('concepto').value;
    this.desactivarConceptosMap[conceptoValor]();
    this.edicionProducto = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.productoData);
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


  guardarProducto(): void {
    if (this.productoFormGroup.invalid) {
      this.productoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IProducto = this.productoFormGroup.getRawValue();
    const conceptoValor = this.productoFormGroup.get('concepto').value;

    dataBody.id = this.productoData.id;
    dataBody.estado = this.productoData.estado;

    dataBody.prodEmpresaId = this.productoData.prodEmpresaId;
    dataBody.fechaCreacion = this.productoData.fechaCreacion;
    dataBody.fechaModificacion = this.productoData.fechaModificacion;

    if (conceptoValor === tipoConceptoEnum.CUPS) {
      dataBody.prodIumId = null;
      dataBody.prodCumId = null;
      dataBody.prodOtroProductoId = null;
      dataBody.prodCupId = +dataBody.prodCupId ?? null;
    } else
    if (conceptoValor === tipoConceptoEnum.MEDICAMENTOS) {
      dataBody.prodIumId = +dataBody.prodIumId ?? null;
      dataBody.prodCumId = +dataBody.prodCumId ?? null;
      dataBody.prodOtroProductoId = null;
      dataBody.prodCupId = null;
    } else
    if (conceptoValor === tipoConceptoEnum.OTROS_PRODUCTOS) {
      dataBody.prodIumId = null;
      dataBody.prodCumId = null;
      dataBody.prodOtroProductoId = +dataBody.prodOtroProductoId ?? null;
      dataBody.prodCupId = null;
    }

    this.productoService.actualizarProducto(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.conceptoInicial = '';
          this.productoData = this.productoFormGroup.getRawValue();
          this.productoData.prodEmpresaId = dataBody.prodEmpresaId;
          this.productoData.estado = dataBody.estado;
          this.productoData.prodEmpresaId = dataBody.prodEmpresaId;
          this.productoData.fechaCreacion = dataBody.fechaCreacion;
          this.productoData.fechaModificacion = dataBody.fechaModificacion;
          setTimeout(() => {
            this.cancelarEdicion();
          });
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
