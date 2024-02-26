import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CrearCentroCostosComponent } from '../../modals/crear-centro-costos/crear-centro-costos.component';
import { IEmpresa } from 'src/app/models/empresa.model';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { ICentroCostos } from 'src/app/models/centro-costos.model';
import { Observable } from 'rxjs';
import { CentroCostosService } from 'src/app/services/centro-costos-service/centro-costos.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { Router } from '@angular/router';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import swal from 'sweetalert2';

@Component({
  selector: 'app-centro-costos',
  templateUrl: './centro-costos.component.html',
  styleUrls: ['./centro-costos.component.scss']
})
export class CentroCostosComponent implements OnInit {

  centroCostoCollapsed: boolean = false;
  dataEmpresa: IEmpresa;

  listCentroCostosEmpresaObs: Observable<ICentroCostos[]>;

  colsCentroCostosEmpresa: any[] = [
    { field: 'ccosNombre', header: 'Nombre' },
    { field: 'ccosCodigo', header: 'Código' }
  ];

  constructor(
    private modalService: NgbModal,
    private storageService: StorageService,
    private centroCostosService: CentroCostosService,
    private sharedService: SharedService,
    private generalService: GeneralService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTablas();
  }

  cargarTablas(): void {
    this.listCentroCostosEmpresaObs =
      this.centroCostosService.obtenerCentroCostosPorEmpresaId(this.dataEmpresa.id);
  }

  abrirModalCrearCentroCostos(): void {
    const modalCentroCostos = this.modalService.open(
      CrearCentroCostosComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalCentroCostos.componentInstance.empresaID = this.dataEmpresa.id;

    modalCentroCostos.result.then((result) => {
      if (result) {
        this.cargarTablas();
      }
    })
  }

  verCentroCostos(value: ICentroCostos): void {
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['/gestion-centro-costos/editar-centro-costos']);
  }

  alertaEliminarCentroCostos(value: ICentroCostos): void {
    swal.fire({
      title: "¿Esta seguro que desea eliminar estre registro?",
      text: "Este registro se eliminara de forma permanente",
      icon: "warning",
      showCancelButton: true,
      cancelButtonText: 'Cancelar',
      confirmButtonText: "¡Si, Eliminar!"
    }).then((result) => {
      if (result.isConfirmed) {
        this.eliminarCentroCostos(value);
      }
    });
  }

  eliminarCentroCostos(value: ICentroCostos): void {
    this.centroCostosService.eliminarCentroCostos(value.id).subscribe({
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
