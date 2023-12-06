import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private collapseSidebar = new BehaviorSubject<boolean>(true);
  private sucursalEmpresaData = new BehaviorSubject<any>(true);
  collapseSidebarListener$ = this.collapseSidebar.asObservable();
  sucursalEmpresaDataListener$ = this.sucursalEmpresaData.asObservable();

  collapseSidebarValue$ = this.collapseSidebar;

  constructor() { }

  addCollapseSidebar(bool: boolean) {
    this.collapseSidebar.next(bool);
  }

  addSucursalEmpresaData(data: any) {
    this.sucursalEmpresaData.next(data);
  }
}
