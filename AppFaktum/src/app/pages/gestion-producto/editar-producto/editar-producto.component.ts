import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IProducto } from 'src/app/models/producto.model';
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
  }

  cargarListaCombox(): void {

  }

  obtenerProducto(data: IProducto): void {
    this.centroCostosService.obtenerCentroCostosPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          // this.productoData = response.data;
          // this.cargarDataForm(response.data);
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
      prodCumId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodCupId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      prodIumId: [ { value: '', disabled: false }, [
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
      prodOtroProductoId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
    };

    this.productoFormGroup = this.fb.group(formControls);
  }


  guardarProducto(): void {
    if (this.productoFormGroup.invalid) {
      this.productoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IProducto = this.productoFormGroup.getRawValue();

    // dataBody.id = this.centroCostosData.id;
    // dataBody.estado = this.centroCostosData.estado;

    // // toca hablar de estos dos
    // dataBody.ccosEmpresaId = this.centroCostosData.ccosEmpresaId;
    // dataBody.fechaCreacion = this.centroCostosData.fechaCreacion;
    // dataBody.fechaModificacion = this.centroCostosData.fechaModificacion;

    this.productoService.actualizarProducto(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.productoFormGroup.disable();
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
