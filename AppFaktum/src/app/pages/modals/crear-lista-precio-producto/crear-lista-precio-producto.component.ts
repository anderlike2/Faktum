import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, Mensajes, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListaPrecioProducto } from 'src/app/models/lista-precio-producto.model';
import { IProducto } from 'src/app/models/producto.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ListaPrecioProductoService } from 'src/app/services/lista-precio-producto-service/lista-precio-producto.service';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-crear-lista-precio-producto',
  templateUrl: './crear-lista-precio-producto.component.html',
  styleUrls: ['./crear-lista-precio-producto.component.scss']
})
export class CrearListaPrecioProductoComponent implements OnInit {

  @Input() listaPrecioID: number;

  dataEmpresa: IEmpresa;
  listProductos: IProducto[];
  listPrecioProductos: IListaPrecioProducto[];
  

  colsProductos: any[] = [
    { field: 'prodCodigo', header: 'Código' },
    { field: 'prodNombreTecnico', header: 'Nombre' },
    { field: 'prodMarca', header: 'Marca' },
    { field: 'prodValor', header: 'Valor Original' },
    { field: 'prodModelo', header: 'Modelo' }
  ];

  constructor(private modalRef: NgbActiveModal, private storageService: StorageService, private productoService: ProductoService,
    private generalService: GeneralService, private listaPrecioProductoService: ListaPrecioProductoService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTablas();
  }

  cargarTablas(): void {
    this.productoService.obtenerProductosPorEmpresaid(this.dataEmpresa.id) 
    .subscribe({
      next: (response) => {
        this.listProductos = response;
        this.listProductos.forEach(element => {
          element.prodSeleccionado = false;
        });
      }
    });
  }

  guardarProductos(): void {
    this.listPrecioProductos = [];
    let productosSeleccionados = this.listProductos.filter(x => x.prodSeleccionado);
    let validacionesCorrectas = true;
    productosSeleccionados.forEach(element => {
      if(element.prodValorLista == null || element.prodValorLista <= 0 || element.prodValorDescuento == null || element.prodValorDescuento <= 0){
        this.generalService.mostrarMensajeAlerta(Mensajes.MSG_VALORES_OBLIGATORIOS, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        validacionesCorrectas = false;
      }else{
        let itemListaPrecio = {} as IListaPrecioProducto;
        itemListaPrecio.id = 0;
        itemListaPrecio.lproValor = element.prodValorLista;
        itemListaPrecio.lproDescuento = element.prodValorDescuento;
        itemListaPrecio.lproListaPrecioId = this.listaPrecioID;
        itemListaPrecio.lproProductoId = element.id;
        itemListaPrecio.estado = 1;
        
        this.listPrecioProductos.push(itemListaPrecio);        
      }
    });   

    if(validacionesCorrectas){
      this.listaPrecioProductoService.crearListaPrecio(this.listPrecioProductos).subscribe({
        next: (response: any) => {
          if (!response?.success) {
            this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
          }else{
            this.cerrarModal(true);
            this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
          }
        }
      });
    }   
  }

  cerrarModal(info?: any) {
    this.modalRef.close(info);
  }

}
