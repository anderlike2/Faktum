import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IResolucion } from 'src/app/models/resolucion.model';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { ResolucionService } from 'src/app/services/resolucion-service/resolucion.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CrearResolucionComponent } from '../../modals/crear-resolucion/crear-resolucion.component';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { Router } from '@angular/router';
import swal from 'sweetalert2';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-resoluciones',
  templateUrl: './resoluciones.component.html',
  styleUrls: ['./resoluciones.component.scss']
})
export class ResolucionesComponent implements OnInit {

  resolucionCollapsed: boolean = false;
  dataEmpresa: IEmpresa;

  listResolucionesObs: Observable<IResolucion[]>;

  colsResoluciones: any[] = [
    { field: 'resoAnio', header: 'Año' },
    { field: 'resoConsActual', header: 'Cons. Actual' },
    { field: 'resoConsFinal', header: 'Cons. Final' },
    { field: 'resoConsInicial', header: 'Cons. Inicial' },
    { field: 'resoVigencia', header: 'Fecha Vigencia' },
    { field: 'resoCodigo', header: 'Código' },
    { field: 'resoNumeracionActual', header: 'Numeración Actual' }
  ];

  constructor(
    private storageService: StorageService,
    private resolucionService: ResolucionService,
    private modalService: NgbModal,
    private sharedService: SharedService,
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

  cargarTablas(): void {
    this.listResolucionesObs =
      this.resolucionService.obtenerResolucionesPorEmpresaId(this.dataEmpresa.id);
  }

  abrirResoluciones(): void {
    const modalResoluciones= this.modalService.open(
      CrearResolucionComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalResoluciones.componentInstance.empresaID = this.dataEmpresa.id;

    modalResoluciones.result.then((result) => {
      if (result) {
        this.cargarTablas();
      }
    });
  }

  verResolucion(value: IResolucion): void {
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['/gestion-resolucion/editar-resolucion']);
  }

  alertaEliminarResolucion(value: IResolucion): void {
    swal.fire({
      title: "¿Esta seguro que desea eliminar estre registro?",
      text: "Este registro se eliminara de forma permanente",
      icon: "warning",
      showCancelButton: true,
      cancelButtonText: 'Cancelar',
      confirmButtonText: "¡Si, Eliminar!"
    }).then((result) => {
      if (result.isConfirmed) {
        this.eliminarResolucion(value);
      }
    });
  }

  eliminarResolucion(value: IResolucion): void {
    this.resolucionService.eliminarResolucion(value.id).subscribe({
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
