import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { map } from 'rxjs/operators';
import { ICentroCostos } from 'src/app/models/centro-costos.model';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IProducto } from 'src/app/models/producto.model';
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

    this.cargueCombosService.obtenerListaReteFuente().subscribe({
      next: (response) => this.listaCodRetencionFuente = response
    });

    this.cargueCombosService.obtenerListaTablaImpuestos().subscribe({
      next: (response) => this.listaTipoImpuesto = response
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
