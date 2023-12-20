import { Component, OnInit } from '@angular/core';
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
export class EditarProductoComponent implements OnInit {

  productoCollapsed: boolean = false;
  edicionCentroCostos: boolean = false;

  productoData: IProducto;

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

  ngOnInit(): void {
    this.init();
  }

  init(): void {

    this.sharedService.productoDataListener$.subscribe(this.obtenerProducto.bind(this));

    this.initForm();
    this.cargarListaCombox();
    this.iniConcepto();
  }

  cargarListaCombox(): void {

    this.centroCostosService.obtenerCentroCostosPorEmpresaId(this.productoData.prodEmpresaId)
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

    this.cargueCombosService.obtenerListaReteFuente().subscribe({
      next: (response) => this.listaCodRetencionFuente = response
    });

    this.cargueCombosService.obtenerListaTablaImpuestos().subscribe({
      next: (response) => this.listaTipoImpuesto = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_ARCHIVO_RIPS).subscribe({
      next: (response) => this.listaTipoRips = response
    });

    this.cargueCombosService.obtenerListaUnidadesEmpresa(this.productoData.prodEmpresaId).subscribe({
      next: (response) => this.listaUnidad = response
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_CUPS).subscribe({
      next: (response) => this.listaTipoCups = response
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

    this.cargueCombosService.obtenerListaOtroProductoPorEmpresa(this.productoData.prodEmpresaId).subscribe({
      next: (response) => this.listaOtroProducto = response
    });
  }

  obtenerProducto(data: IProducto): void {
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

  cargarDataForm(data: IProducto): void {
    this.productoFormGroup.disable();
    this.edicionCentroCostos = false;
    this.productoFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.productoFormGroup.enable();
    this.edicionCentroCostos = true;
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
      prodListaPrecio: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodCentroCostoId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodCodReteFuenteId: [ { value: '', disabled: false }, [
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

    const dataBody: IProducto = this.productoFormGroup.value;

    dataBody.id = this.productoData.id;
    dataBody.estado = this.productoData.estado;

    dataBody.prodEmpresaId = this.productoData.prodEmpresaId;
    dataBody.fechaCreacion = this.productoData.fechaCreacion;
    dataBody.fechaModificacion = this.productoData.fechaModificacion;

    this.productoService.actualizarProducto(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
