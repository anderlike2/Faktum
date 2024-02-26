import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CrearListaPrecioComponent } from '../../modals/crear-lista-precio/crear-lista-precio.component';
import { IEmpresa } from 'src/app/models/empresa.model';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { IListaPrecio } from 'src/app/models/lista-precio.model';
import { ListaPrecioService } from 'src/app/services/lista-precio-service/lista-precio.service';
import { Router } from '@angular/router';
import swal from 'sweetalert2';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-listas-precios',
  templateUrl: './listas-precios.component.html',
  styleUrls: ['./listas-precios.component.scss']
})
export class ListasPreciosComponent implements OnInit {

  listaPrecioCollapsed: boolean = false;
  collapseListaPrecio: boolean = false;
  dataEmpresa: IEmpresa;

  listListaPrecios: IListaPrecio[] = [];
  seletedListaPrecio: any;

  colsListaPreciosProducto: any[] = [
    { field: 'liprNombre', header: 'Nombre' },
    { field: 'liprDescripcion', header: 'Descripción' }
  ];

  constructor(
    private modalService: NgbModal,
    private sharedService: SharedService,
    private storageService: StorageService,
    private listaPrecioService: ListaPrecioService,
    private router: Router,
    private generalService: GeneralService
    ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTablas();
  }

  cargarTablas(): void{
    this.listaPrecioService.obtenerListaPrecioPorEmpresa(this.dataEmpresa.id)
    .subscribe({
      next: (response) => {
        this.listListaPrecios = response;
      }
    });
  }

  abrirModalListaPrecio(): void {
    const modalListaPrecio = this.modalService.open(
      CrearListaPrecioComponent, {
        size: 'xl',
        backdrop: false
      }
    );
    modalListaPrecio.componentInstance.empresaID = this.dataEmpresa.id;

    modalListaPrecio.result.then((result) => {
      if (result) {
        this.cargarTablas();
      }
    });
  }

  verListaPrecio(value:IListaPrecio): void{
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['./gestion-lista-precio/editar-lista-precio']);
  }

  alertaEliminarListaPrecio(value: IListaPrecio): void {
    swal.fire({
      title: "¿Esta seguro que desea eliminar estre registro?",
      text: "Este registro se eliminara de forma permanente",
      icon: "warning",
      showCancelButton: true,
      cancelButtonText: 'Cancelar',
      confirmButtonText: "¡Si, Eliminar!"
    }).then((result) => {
      if (result.isConfirmed) {
        this.eliminarListaPrecios(value);
      }
    });
  }

  eliminarListaPrecios(value: IListaPrecio): void {
    this.listaPrecioService.eliminarListaPrecio(value.id).subscribe({
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
