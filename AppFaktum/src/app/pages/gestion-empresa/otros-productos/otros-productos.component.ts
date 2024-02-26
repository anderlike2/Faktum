import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IOtroProducto } from 'src/app/models/otro-producto.model';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { OtroProductoService } from 'src/app/services/otro-producto-service/otro-producto.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { Router } from '@angular/router';
import { CrearOtroProductoComponent } from '../../modals/crear-otro-producto/crear-otro-producto.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import swal from 'sweetalert2';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-otros-productos',
  templateUrl: './otros-productos.component.html',
  styleUrls: ['./otros-productos.component.scss']
})
export class OtrosProductosComponent implements OnInit {

  otroProductoCollapsed: boolean = false;
  dataEmpresa: IEmpresa;

  listOtrosProductosObs: Observable<IOtroProducto[]>;

  colsOtrosProductos: any[] = [
    { field: 'otprNombre', header: 'Nombre' },
    { field: 'otprCodigo', header: 'Código' }
  ];

  constructor(
    private storageService: StorageService,
    private otroProductoService: OtroProductoService,
    private sharedService: SharedService,
    private router: Router,
    private modalService: NgbModal,
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
    this.listOtrosProductosObs =
      this.otroProductoService.obtenerOtrosProductosPorEmpresaId(this.dataEmpresa.id);
  }

  abrirOtrosProductos(): void {
    const modalOtrosProductos = this.modalService.open(
      CrearOtroProductoComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalOtrosProductos.componentInstance.empresaID = this.dataEmpresa.id;

    modalOtrosProductos.result.then((result) => {
      if (result) {
        this.cargarTablas();
      }
    });
  }

  verOtroProducto(value: IOtroProducto): void {
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['/gestion-otro-producto/editar-otro-producto']);
  }

  alertaEliminarOtroProducto(value: IOtroProducto): void {
    swal.fire({
      title: "¿Esta seguro que desea eliminar estre registro?",
      text: "Este registro se eliminara de forma permanente",
      icon: "warning",
      showCancelButton: true,
      cancelButtonText: 'Cancelar',
      confirmButtonText: "¡Si, Eliminar!"
    }).then((result) => {
      if (result.isConfirmed) {
        this.eliminarOtroProducto(value);
      }
    });
  }

  eliminarOtroProducto(value: IOtroProducto): void {
    this.otroProductoService.eliminarOtroProducto(value.id).subscribe({
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
