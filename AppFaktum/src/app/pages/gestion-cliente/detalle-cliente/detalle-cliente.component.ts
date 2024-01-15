import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { IClienteEmpresa } from 'src/app/models/cliente-empresa.model';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { CrearClienteComponent } from '../../modals/crear-cliente/crear-cliente.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
@Component({
  selector: 'app-detalle-cliente',
  templateUrl: './detalle-cliente.component.html',
  styleUrls: ['./detalle-cliente.component.scss']
})
export class DetalleClienteComponent implements OnInit {

  clienteCollapsed: boolean = false;

  listClientesEmpresaObs: Observable<IClienteEmpresa[]>;
  dataEmpresa: IEmpresa;

  colsClientesEmpresa: any[] = [
    { field: 'cliePrimerNom', header: 'Primer nombre' },
    { field: 'clieSegundoNom', header: 'Segundo nombre' },
    { field: 'clieApellidos', header: 'Apellidos' },
    { field: 'clieCorreo', header: 'Correo' },
    { field: 'clieCelular', header: 'Teléfono' }
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
    this.listClientesEmpresaObs =
      this.detalleEmpresaService.obtenerInformacionClientesEmpresaId(this.dataEmpresa.id);
  }

  abrirModalCrearCliente(): void {
    const modalCliente = this.modalService.open(
      CrearClienteComponent, {
        size: 'xl',
        backdrop: false
      }
    );

    modalCliente.componentInstance.empresaID = this.dataEmpresa.id;

    modalCliente.result.then((result) => {
      if (result) {
        this.cargarTabla();
      }
    });
  }

  verCliente(value: IClienteEmpresa): void {
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['./gestion-cliente/editar-cliente']);
  }
}
