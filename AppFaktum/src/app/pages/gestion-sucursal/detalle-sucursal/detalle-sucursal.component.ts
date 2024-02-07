import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { IEmpresa } from 'src/app/models/empresa.model';
import { ISucursalEmpresa } from 'src/app/models/sucursal-empresa.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { CrearSucursalComponent } from '../../modals/crear-sucursal/crear-sucursal.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-detalle-sucursal',
  templateUrl: './detalle-sucursal.component.html',
  styleUrls: ['./detalle-sucursal.component.scss']
})
export class DetalleSucursalComponent implements OnInit {

  sucursalCollapsed: boolean = false;

  listSucursalesEmpresaObs: Observable<ISucursalEmpresa[]>;

  dataEmpresa: IEmpresa;

  colsSucursalesEmpresa: any[] = [
    { field: 'sucuNombre', header: 'Nombre' },
    { field: 'sucuCodigo', header: 'Código' },
    { field: 'sucuContacto', header: 'Contacto' },
    { field: 'sucuMail', header: 'Correo' },
    { field: 'sucuTelefono', header: 'Teléfono' }
  ];

  constructor(
    private detalleEmpresaService: DetalleEmpresaService,
    private sharedService: SharedService,
    private storageService: StorageService,
    private router: Router,
    private modalService: NgbModal
  ) { }

  ngOnInit(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTabla();
  }

  cargarTabla(): void {
    this.listSucursalesEmpresaObs =
      this.detalleEmpresaService.obtenerInformacionSucursalesEmpresaId(this.dataEmpresa.id);
  }

  abrirModalCrearSucursal(): void {
    const modalSucursal = this.modalService.open(
      CrearSucursalComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalSucursal.componentInstance.empresaID = this.dataEmpresa.id;
    modalSucursal.result.then((result) => {
      if (result) {
        this.cargarTabla();
      }
    });
  }

  verSucursal(value: ISucursal): void {
    this.sharedService.addSucursalEmpresaData(value);
    this.router.navigate(['/gestion-sucursal/editar-sucursal']);
  }

}
