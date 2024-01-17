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

  constructor(private storageService: StorageService, private resolucionService: ResolucionService,
    private modalService: NgbModal, private sharedService: SharedService, private router: Router) { }

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
    this.sharedService.addResolucionData(value);
    this.router.navigate(['/gestion-resolucion/editar-resolucion']);
  }

}
