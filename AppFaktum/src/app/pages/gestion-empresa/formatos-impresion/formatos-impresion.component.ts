import { Component, OnInit } from '@angular/core';
import { CrearFormatoImpresionComponent } from '../../modals/crear-formato-impresion/crear-formato-impresion.component';
import { IEmpresa } from 'src/app/models/empresa.model';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { Router } from '@angular/router';
import { IFormatoImpresion } from 'src/app/models/formato-impresion.model';
import { Observable } from 'rxjs';
import { FormatoImpresionService } from 'src/app/services/formato-impresion-service/formato-impresion.service';
import swal from 'sweetalert2';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';

@Component({
  selector: 'app-formatos-impresion',
  templateUrl: './formatos-impresion.component.html',
  styleUrls: ['./formatos-impresion.component.scss']
})
export class FormatosImpresionComponent implements OnInit {

  formatoImpresionCollapsed: boolean = false;
  dataEmpresa: IEmpresa;

  listFormatosImpresionObs: Observable<IFormatoImpresion[]>;

  colsFormatosImpresionEmpresa: any[] = [
    { field: 'formNombre', header: 'Nombre' },
    { field: 'formCodigo', header: 'Código' }
  ];

  constructor(
    private modalService: NgbModal,
    private storageService: StorageService,
    private sharedService: SharedService,
    private router: Router,
    private formatoImpresionService: FormatoImpresionService,
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
    this.listFormatosImpresionObs =
      this.formatoImpresionService.obtenerFormatosImpresionPorEmpresaId(this.dataEmpresa.id);
  }

  abrirModalFormatosImpresion(): void {
    const modalFormatosImpresion = this.modalService.open(
      CrearFormatoImpresionComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalFormatosImpresion.componentInstance.empresaID = this.dataEmpresa.id;

    modalFormatosImpresion.result.then((result) => {
      if (result) {
        this.cargarTablas();
      }
    })
  }

  verFormatoImpresion(value: IFormatoImpresion): void {
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['/gestion-formato-impresion/editar-formato-impresion']);
  }

  alertaEliminarFormatoImpresion(value: IFormatoImpresion): void {
    swal.fire({
      title: "¿Esta seguro que desea eliminar estre registro?",
      text: "Este registro se eliminara de forma permanente",
      icon: "warning",
      showCancelButton: true,
      cancelButtonText: 'Cancelar',
      confirmButtonText: "¡Si, Eliminar!"
    }).then((result) => {
      if (result.isConfirmed) {
        this.eliminarFormatoImpresion(value);
      }
    });
  }

  eliminarFormatoImpresion(value: IFormatoImpresion): void {
    this.formatoImpresionService.eliminarFormatoImpresion(value.id).subscribe({
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
