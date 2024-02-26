import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IEmpresa } from 'src/app/models/empresa.model';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { CrearProductoComponent } from '../../modals/crear-producto/crear-producto.component';
import { IProducto } from 'src/app/models/producto.model';
import { Observable } from 'rxjs';
import { MostrarInformacionComponent } from '../../modals/mostrar-informacion/mostrar-informacion.component';
import swal from 'sweetalert2';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-detalle-producto',
  templateUrl: './detalle-producto.component.html',
  styleUrls: ['./detalle-producto.component.scss']
})
export class DetalleProductoComponent implements OnInit {

  productoCollapsed: boolean = false;
  dataEmpresa: IEmpresa;

  listProductoObs: Observable<IProducto[]>;

  colsProducto: any[] = [
    { field: 'prodCodigo', header: 'Código' },
    { field: 'prodNombreFactura', header: 'Descripción' },
    { field: 'prodValor', header: 'Valor' },
    { field: '', header: 'Concepto' }
  ];

  constructor(
    private modalService: NgbModal,
    private storageService: StorageService,
    private sharedService: SharedService,
    private router: Router,
    private productoService: ProductoService,
    private generalService: GeneralService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTablas();
  }

  cargarTablas(): void {
    this.listProductoObs =
      this.productoService.obtenerProductosPorEmpresaid(this.dataEmpresa.id);
  }

  abrirModalCrearProducto(): void {
    const modalProducto = this.modalService.open(
      CrearProductoComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalProducto.componentInstance.empresaID = this.dataEmpresa.id;
    modalProducto.result.then((result) => {
      if (result) {
        this.cargarTablas();
      }
    });
  }

  verProducto(value: IProducto): void {
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['/gestion-producto/editar-producto']);
  }

  verNombreTecnico(value: IProducto): void {
    const modalDetalle = this.modalService.open(
      MostrarInformacionComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalDetalle.componentInstance.informacionMostrar = value.prodNombreTecnico;
  }

  obtenerNombreConcepto(value: IProducto){
    return value.prodCupId != null ? 'CUPS' : (value.prodOtroProductoId != null ? 'OTROS PRODUCTOS' : 'MEDICAMENTOS');
  }

  alertaEliminarProducto(value: IProducto): void {
    swal.fire({
      title: "¿Esta seguro que desea eliminar estre registro?",
      text: "Este registro se eliminara de forma permanente",
      icon: "warning",
      showCancelButton: true,
      cancelButtonText: 'Cancelar',
      confirmButtonText: "¡Si, Eliminar!"
    }).then((result) => {
      if (result.isConfirmed) {
        this.eliminarProducto(value);
      }
    });
  }

  eliminarProducto(value: IProducto): void {
    this.productoService.eliminarProduto(value.id).subscribe({
      next: (response) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        } else {
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
           this.cargarTablas();
        }
      }
    });
  }

}
