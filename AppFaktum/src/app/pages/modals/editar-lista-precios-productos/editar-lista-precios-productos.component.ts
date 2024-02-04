import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListaPrecioProducto } from 'src/app/models/lista-precio-producto.model';
import { IListaPrecio } from 'src/app/models/lista-precio.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ListaPrecioProductoService } from 'src/app/services/lista-precio-producto-service/lista-precio-producto.service';
import { ListaPrecioService } from 'src/app/services/lista-precio-service/lista-precio.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-editar-lista-precios-productos',
  templateUrl: './editar-lista-precios-productos.component.html',
  styleUrls: ['./editar-lista-precios-productos.component.scss']
})
export class EditarListaPreciosProductosComponent implements OnInit {

  @Input() listaPrecioProductoID: number;
  @Input() listaPrecioID: number;
  listListaPrecios: IListaPrecio[] = [];

  listaPrecioProductoFormGroup: FormGroup;
  fb = new FormBuilder();
  dataEmpresa: IEmpresa;
  dataListaPrecioProducto: IListaPrecioProducto;

  constructor(private listaPrecioService: ListaPrecioService, private storageService: StorageService, private modalRef: NgbActiveModal,
    private listaPrecioProductoService: ListaPrecioProductoService, private generalService: GeneralService) { }

  ngOnInit(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarListaCombox();
    this.obtenerListaPrecioProductoId(this.listaPrecioProductoID);
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      lproListaPrecioId: [ { value: '', disabled: false }, [ Validators.required ] ],
      lproValor: [ { value: '', disabled: false }, [ Validators.required ] ],
      lproDescuento: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.listaPrecioProductoFormGroup = this.fb.group(formControls);
  }

  cargarListaCombox(): void {
    this.listaPrecioService.obtenerListaPrecioPorEmpresa(this.dataEmpresa.id)
    .subscribe({
      next: (response) => {
        this.listListaPrecios = response;
      }
    });
  }

  obtenerListaPrecioProductoId(id: number): void {
    this.listaPrecioProductoService.obtenerListaPrecioProductoPorId(id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.dataListaPrecioProducto = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  get lproListaPrecioIdErrorMensaje(): string {
    const form: AbstractControl = this.listaPrecioProductoFormGroup.get('lproListaPrecioId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get lproValorErrorMensaje(): string {
    const form: AbstractControl = this.listaPrecioProductoFormGroup.get('lproValor') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get lproDescuentoErrorMensaje(): string {
    const form: AbstractControl = this.listaPrecioProductoFormGroup.get('lproDescuento') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  cargarDataForm(data: IListaPrecioProducto): void {
    this.listaPrecioProductoFormGroup.patchValue(
      data
    );
  }

  actualizarProducto(): void{
    if (this.listaPrecioProductoFormGroup.invalid) {
      this.listaPrecioProductoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IListaPrecioProducto = this.listaPrecioProductoFormGroup.getRawValue();

    dataBody.id = this.dataListaPrecioProducto.id;
    dataBody.estado = this.dataListaPrecioProducto.estado;
    dataBody.lproProductoId = this.dataListaPrecioProducto.lproProductoId;
    dataBody.fechaCreacion = this.dataListaPrecioProducto.fechaCreacion;
    dataBody.fechaModificacion = this.dataListaPrecioProducto.fechaModificacion;
    dataBody.lproListaPrecioAnteriorId = this.listaPrecioID;

    this.listaPrecioProductoService.actualizarListaPrecio(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);          
        }else{
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
          this.cerrarModal(true);
        }
      }
    });
  }

  cerrarModal(info?: any) {
    this.modalRef.close(info);
  }

}
