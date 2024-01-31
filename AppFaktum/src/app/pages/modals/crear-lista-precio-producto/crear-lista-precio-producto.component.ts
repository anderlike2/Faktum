import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IProductoLista } from 'src/app/models/producto-lista.model';
import { IProducto } from 'src/app/models/producto.model';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-crear-lista-precio-producto',
  templateUrl: './crear-lista-precio-producto.component.html',
  styleUrls: ['./crear-lista-precio-producto.component.scss']
})
export class CrearListaPrecioProductoComponent implements OnInit {

  dataEmpresa: IEmpresa;
  listProductoObs: Observable<IProducto[]>;
  lstProductosGuardar: IProductoLista[];

  colsProductos: any[] = [
    { field: 'prodCodigo', header: 'Código' },
    { field: 'prodMarca', header: 'Marca' },
    { field: 'prodValor', header: 'Valor Original' },
    { field: 'prodModelo', header: 'Modelo' }
  ];

  constructor(private modalRef: NgbActiveModal, private storageService: StorageService, private productoService: ProductoService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTablas();
  }

  cargarTablas(): void {
    this.listProductoObs = this.productoService.obtenerProductosPorEmpresaid(this.dataEmpresa.id);
    this.listProductoObs.subscribe(this.transformarDatos);
  }

  guardarProductos(): void {
    this.cerrarModal(true);
  }

  cerrarModal(info?: any) {
    this.modalRef.close(info);
  }

  seleccionarProducto(item: IProductoLista){
  }

  transformarDatos(datos) {
    /*let nuevoProducto = new IProductoLista();
    datos.forEach(element => {
      
      nuevoProducto.id = element.id;
      nuevoProducto.prodCodigo = element.prodCodigo;
      nuevoProducto.prodMarca = element.prodMarca;
      nuevoProducto.prodModelo = element.prodModelo;
      nuevoProducto.prodValor = element.prodValor;
      nuevoProducto.prodValorLista = 0;
      nuevoProducto.prodValorDescuento = 0;
      nuevoProducto.prodSeleccionado = false;
      this.lstProductosGuardar.push(nuevoProducto);
    });*/
 }
}
