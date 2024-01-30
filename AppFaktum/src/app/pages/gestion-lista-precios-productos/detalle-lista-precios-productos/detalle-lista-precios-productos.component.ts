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
    { field: 'lproProducto.prodNombreTecnico', header: 'Nombre' },
    { field: 'lproProducto.prodMarca', header: 'Marca' },
    { field: 'lproProducto.prodValor', header: 'Valor Original' },
    { field: 'lproValor', header: 'Valor Lista Precio' },
    { field: 'lproDescuento', header: 'Descuento' }
  ];

  constructor(private listaPrecioService: ListaPrecioService, private storageService: StorageService, private listaPrecioProductoService: ListaPrecioProductoService,
    private modalService: NgbModal) { }

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

  eliminarProducto(idEliminar: number): void{
    const modalConfirmacion = this.modalService.open(
      ConfirmacionComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalConfirmacion.result.then((result) => {
      if (result) {
        
      }
    })
  }

}
