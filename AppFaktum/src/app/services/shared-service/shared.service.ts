import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private collapseSidebar = new BehaviorSubject<boolean>(true);
  private sucursalEmpresaData = new BehaviorSubject<any>(undefined);
  private clienteEmpresaData = new BehaviorSubject<any>(true);
  private sucursalClienteData = new BehaviorSubject<any>(true);
  private contratoClienteData = new BehaviorSubject<any>(undefined);
  private centroCostosData = new BehaviorSubject<any>(undefined);
  private formatoImpresionData = new BehaviorSubject<any>(undefined);
  collapseSidebarListener$ = this.collapseSidebar.asObservable();
  sucursalEmpresaDataListener$ = this.sucursalEmpresaData.asObservable();
  clienteEmpresaDataListener$ = this.clienteEmpresaData.asObservable();
  sucursalClienteDataListener$ = this.sucursalClienteData.asObservable();
  contratoClienteDataListener$ = this.contratoClienteData.asObservable();
  centroCostosDataListener$ = this.centroCostosData.asObservable();
  formatoImpresionDataListener$ = this.formatoImpresionData.asObservable();

  collapseSidebarValue$ = this.collapseSidebar;

  constructor() { }

  addCollapseSidebar(bool: boolean) {
    this.collapseSidebar.next(bool);
  }

  addSucursalEmpresaData(data: any) {
    this.sucursalEmpresaData.next(data);
  }

  addClienteEmpresaData(data: any) {
    this.clienteEmpresaData.next(data);
  }

  addSucursalClienteData(data: any) {
    this.sucursalClienteData.next(data);
  }

  addContratoClienteData(data: any) {
    this.contratoClienteData.next(data);
  }

  addCentroCostosData(data: any) {
    this.centroCostosData.next(data);
  }

  addFormatoImpresionData(data: any) {
    this.formatoImpresionData.next(data);
  }
}
