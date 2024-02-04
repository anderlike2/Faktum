import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IListaPrecio } from 'src/app/models/lista-precio.model';
import { IListaPrecioProducto } from 'src/app/models/lista-precio-producto.model';
import { ListaPrecioService } from 'src/app/services/lista-precio-service/lista-precio.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { ListaPrecioProductoService } from 'src/app/services/lista-precio-producto-service/lista-precio-producto.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmacionComponent } from '../../modals/confirmacion/confirmacion.component';
import { CrearListaPrecioProductoComponent } from '../../modals/crear-lista-precio-producto/crear-lista-precio-producto.component';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { GeneralesEnum, Mensajes, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { EditarListaPreciosProductosComponent } from '../../modals/editar-lista-precios-productos/editar-lista-precios-productos.component';

@Component({
  selector: 'app-detalle-lista-precios-productos',
  templateUrl: './detalle-lista-precios-productos.component.html',
  styleUrls: ['./detalle-lista-precios-productos.component.scss']
})
export class DetalleListaPreciosProductosComponent implements OnInit {

  listaPrecioProductoCollapsed: boolean = false;

  listListaPrecios: IListaPrecio[] = [];
  dataEmpresa: IEmpresa;

  listaPrecioFormGroup: FormGroup;
  fb = new FormBuilder();

  listProductosListaPrecioObs: Observable<IListaPrecioProducto[]>;

  colsProductosListaPrecio: any[] = [
    { field: 'lproProducto', child: 'prodNombreTecnico', header: 'Nombre' },
    { field: 'lproProducto', child: 'prodMarca', header: 'Marca' },
    { field: 'lproProducto', child: 'prodValor', header: 'Valor Original' },
    { field: 'lproValor', header: 'Valor Lista Precio' },
    { field: 'lproDescuento', header: 'Descuento' }
  ];

  constructor(private listaPrecioService: ListaPrecioService, private storageService: StorageService, private listaPrecioProductoService: ListaPrecioProductoService,
    private modalService: NgbModal, private generalService: GeneralService) { }

  ngOnInit(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.listaPrecioService.obtenerListaPrecioPorEmpresa(this.dataEmpresa.id)
    .subscribe({
      next: (response) => {
        this.listListaPrecios = response;
      }
    });

    this.initForm();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      lproListaPrecioId: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.listaPrecioFormGroup = this.fb.group(formControls);
  }

  cargarProductos(idListaPrecio: number): void{
    this.listProductosListaPrecioObs =
      this.listaPrecioProductoService.obtenerProductosPorListaPrecio(idListaPrecio);
  }

  eliminarProducto(listaPrecio: IListaPrecioProducto): void{
    const modalConfirmacion = this.modalService.open(
      ConfirmacionComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalConfirmacion.result.then((result) => {
      if (result) {
        this.listaPrecioProductoService.eliminarListaPrecio(listaPrecio).subscribe({
          next: (response: any) => {
            if (!response?.success) {
              this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
            }else{
              this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
              this.cargarProductos(this.listaPrecioFormGroup.controls['lproListaPrecioId'].value);
            }
          }
        });
      }
    })
  }

  abrirModalListaPrecioProducto(): void {
    let valorListaPrecio = this.listaPrecioFormGroup.controls['lproListaPrecioId'].value;
    if(valorListaPrecio == undefined || valorListaPrecio == ''){
      this.generalService.mostrarMensajeAlerta(Mensajes.MSG_SELECCIONA_LISTA_PRECIO, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
      return;
    }

    const modalListaPrecioProducto = this.modalService.open(
      CrearListaPrecioProductoComponent, {
        size: 'xl',
        backdrop: false
      }
    );
    modalListaPrecioProducto.componentInstance.listaPrecioID = this.listaPrecioFormGroup.controls['lproListaPrecioId'].value;

    modalListaPrecioProducto.result.then((result) => {
      if (result) {
        this.cargarProductos(this.listaPrecioFormGroup.controls['lproListaPrecioId'].value);
      }
    });
  }

  abrirModalEditarListaPrecioProducto(id: number): void {

    const modalListaPrecioProducto = this.modalService.open(
      EditarListaPreciosProductosComponent, {
        size: 'xl',
        backdrop: false
      }
    );
    modalListaPrecioProducto.componentInstance.listaPrecioProductoID = id;
    modalListaPrecioProducto.componentInstance.listaPrecioID = this.listaPrecioFormGroup.controls['lproListaPrecioId'].value;

    modalListaPrecioProducto.result.then((result) => {
      if (result) {
        this.cargarProductos(this.listaPrecioFormGroup.controls['lproListaPrecioId'].value);
      }
    });
  }

}
