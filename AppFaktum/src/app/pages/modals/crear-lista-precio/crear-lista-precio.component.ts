import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IListaPrecio } from 'src/app/models/lista-precio.model';
import { IProducto } from 'src/app/models/producto.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ListaPrecioService } from 'src/app/services/lista-precio-service/lista-precio.service';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-crear-lista-precio',
  templateUrl: './crear-lista-precio.component.html',
  styleUrls: ['./crear-lista-precio.component.scss']
})
export class CrearListaPrecioComponent implements OnInit {

  @Input() sucursalClienteID: number;

  listaPrecioFormGroup: FormGroup;
  fb = new FormBuilder();

  dataEmpresa: IEmpresa;
  listProductoObs: IListCombo[] = [];

  constructor(private listaPrecioService: ListaPrecioService,
    private generalService: GeneralService,
    private modalRef: NgbActiveModal,
    private storageService: StorageService,
    private productoService: ProductoService) { }

  ngOnInit(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarListaCombobox();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      liprNombre: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprDescripcion: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprDescuento: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprValor: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprEstadoOperacion: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprProductoId: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.listaPrecioFormGroup = this.fb.group(formControls);
  }

  cargarListaCombobox(): void {
    this.productoService.obtenerProductosPorEmpresaid(this.dataEmpresa.id).pipe(
        map((response) =>
          response.map((item) => ({
            valor: item.id,
            nombre: item.prodNombreTecnico,
            codigo: item.prodCodigo
          })) as IListCombo[]
        )
      )
      .subscribe({
        next: (response) => this.listProductoObs = response
      });
  }

  guardarListaPrecio(): void {
    if (this.listaPrecioFormGroup.invalid) {
      this.listaPrecioFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IListaPrecio = this.listaPrecioFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.liprSucursalClienteId = this.sucursalClienteID;

    this.listaPrecioService.crearListaPrecio(dataBody).subscribe({
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
