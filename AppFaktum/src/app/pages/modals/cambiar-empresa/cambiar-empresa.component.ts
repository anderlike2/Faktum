import { Component, OnInit } from '@angular/core';
import { NgbActiveModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { SessionService } from 'src/app/services/session-service/session.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-cambiar-empresa',
  templateUrl: './cambiar-empresa.component.html',
  styleUrls: ['./cambiar-empresa.component.scss']
})
export class CambiarEmpresaComponent implements OnInit {

  empresas: any[];
  seletedEmpresa: any;
  botonGuardarActivo = false;

  cols: any[] = [
    { field: 'emprNombre', header: 'Empresa' },
    { field: 'emprNit', header: 'Nit' },
    { field: 'emprRepLegal', header: 'Rep. legal' },
    { field: 'emprCiudad', header: 'Ciudad' }
  ];

  constructor(
    private sessionService: SessionService,
    private storageService: StorageService,
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
    this.initEmpresas();
  }

  initEmpresas() {
    const empresasInfo = this.storageService.getEmpresaStorage();
    this.empresas = empresasInfo;
  }

  onRowSelect(event) {
    this.botonGuardarActivo = !this.botonGuardarActivo;
  }

  onRowUnselect(event) {
    this.botonGuardarActivo = !this.botonGuardarActivo;
  }

  guardarEmpresa(): void {
    this.storageService.setEmpresaActivaStorage(this.seletedEmpresa);
    this.modalRef.close();
  }

}
