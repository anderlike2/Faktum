import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbActiveModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';
import { EmpresaService } from 'src/app/services/empresa-service/empresa.service';
import { SessionService } from 'src/app/services/session-service/session.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-cambiar-empresa',
  templateUrl: './cambiar-empresa.component.html',
  styleUrls: ['./cambiar-empresa.component.scss']
})
export class CambiarEmpresaComponent implements OnInit {

  @Input() activarBtnCerrar: boolean = false;

  empresas: Observable<any[]>;
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
    private empresaService: EmpresaService,
    private router: Router,
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
    this.initEmpresas();
  }

  initEmpresas() {
    // const empresasInfo = this.storageService.getEmpresaStorage();
    // this.empresas = empresasInfo;
    const usuario = this.storageService.getUsuarioStorage();
    this.empresas = this.empresaService.consultarEmpresasUsusario(
      usuario.id
    );

  }

  onRowSelect(event) {
    this.botonGuardarActivo = !this.botonGuardarActivo;
  }

  onRowUnselect(event) {
    this.botonGuardarActivo = !this.botonGuardarActivo;
  }

  guardarEmpresa(): void {
    this.storageService.setEmpresaActivaStorage(this.seletedEmpresa);
    this.router.navigateByUrl('/', { skipLocationChange: false }).then(() => {
      window.location.reload();
    });
    this.modalRef.close();
  }

  cerrarModal(): void {
    this.modalRef.close();
  }

}
