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
    { field: 'prodNombreTecnico', header: 'Nombre técnico' },
    { field: 'prodMarca', header: 'Marca' },
    { field: 'prodCodigo', header: 'Código' },
    { field: 'prodValor', header: 'Valor' }
  ];

  constructor(
    private modalService: NgbModal,
    private storageService: StorageService,
    private sharedService: SharedService,
    private router: Router,
    private productoService: ProductoService
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
  }

  verProducto(value: IProducto): void {
    this.sharedService.addProductoData(value);
    this.router.navigate(['/gestion-producto/editar-producto']);
  }

}
