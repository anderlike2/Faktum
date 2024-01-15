import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private collapseSidebar = new BehaviorSubject<boolean>(true);
  private sucursalEmpresaData = new BehaviorSubject<any>(undefined);
  private clienteEmpresaData = new BehaviorSubject<any>(true);
  private contratoClienteData = new BehaviorSubject<any>(undefined);
  private centroCostosData = new BehaviorSubject<any>(undefined);
  private formatoImpresionData = new BehaviorSubject<any>(undefined);
  private unidadData = new BehaviorSubject<any>(undefined);
  private listaPrecioData = new BehaviorSubject<any>(undefined);
  private productoData = new BehaviorSubject<any>(undefined);
  private otroProductoData = new BehaviorSubject<any>(undefined);
  private editarGeneralData = new BehaviorSubject<any>(undefined);
  collapseSidebarListener$ = this.collapseSidebar.asObservable();
  sucursalEmpresaDataListener$ = this.sucursalEmpresaData.asObservable();
  clienteEmpresaDataListener$ = this.clienteEmpresaData.asObservable();
  contratoClienteDataListener$ = this.contratoClienteData.asObservable();
  centroCostosDataListener$ = this.centroCostosData.asObservable();
  formatoImpresionDataListener$ = this.formatoImpresionData.asObservable();
  unidadDataListener$ = this.unidadData.asObservable();
  listaPrecioDataListener$ = this.listaPrecioData.asObservable();
  productoDataListener$ = this.productoData.asObservable();
  otroProductoListener$ = this.otroProductoData.asObservable();
  editarGeneralDataListener$ = this.editarGeneralData.asObservable();

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

  addContratoClienteData(data: any) {
    this.contratoClienteData.next(data);
  }

  addCentroCostosData(data: any) {
    this.centroCostosData.next(data);
  }

  addFormatoImpresionData(data: any) {
    this.formatoImpresionData.next(data);
  }

  addUnidadData(data: any) {
    this.unidadData.next(data);
  }

  addLstaPrecioData(data: any) {
    this.listaPrecioData.next(data);
  }

  addProductoData(data: any) {
    this.productoData.next(data);
  }

  addOtroProductoData(data: any) {
    this.otroProductoData.next(data);
  }

  addEditarGeneralData(data: any) {
    this.editarGeneralData.next(data);
  }
}
