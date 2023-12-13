import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { IClienteEmpresa } from 'src/app/models/cliente-empresa.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
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
    private router: Router
  ) { }

  ngOnInit(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarTabla();
  }

  cargarTabla(): void {
    this.listClientesEmpresaObs =
      this.detalleEmpresaService.obtenerInformacionClientesEmpresaId(this.dataEmpresa.id);
  }

  verCliente(value: IClienteEmpresa): void {
    this.sharedService.addClienteEmpresaData(value);
    this.router.navigate(['./gestion-cliente/editar-cliente']);
  }
}
