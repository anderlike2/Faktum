import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IEmpresa } from 'src/app/models/empresa.model';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { CrearUnidadComponent } from '../../modals/crear-unidad/crear-unidad.component';
import { UnidadService } from 'src/app/services/unidad-service/unidad.service';
import { IUnidad } from 'src/app/models/unidad.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-unidades',
  templateUrl: './unidades.component.html',
  styleUrls: ['./unidades.component.scss']
})
export class UnidadesComponent implements OnInit {

  unidadCollapsed: boolean = false;
  dataEmpresa: IEmpresa;

  listUnidadesObs: Observable<IUnidad[]>;

  colsUnidades: any[] = [
    { field: 'unidNombre', header: 'Nombre' },
    { field: 'unidCodigoDian', header: 'Código Dian' },
    { field: 'unidCodigo', header: 'Código' }
  ];

  constructor(
    private modalService: NgbModal,
    private storageService: StorageService,
    private sharedService: SharedService,
    private router: Router,
    private unidadService: UnidadService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTablas();
  }

  cargarTablas(): void {
    this.listUnidadesObs =
      this.unidadService.obtenerUnidadesPorEmpresaId(this.dataEmpresa.id);
  }

  abrirUnidades(): void {
    const modalUnidades= this.modalService.open(
      CrearUnidadComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalUnidades.componentInstance.empresaID = this.dataEmpresa.id;

    modalUnidades.result.then((result) => {
      if (result) {
        this.cargarTablas();
      }
    });
  }

  verUnidad(value: IUnidad): void {
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['/gestion-unidad/editar-unidad']);
  }

}
