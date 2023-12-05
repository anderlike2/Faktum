import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SessionService {

  constructor() { }

  get isLogged(): boolean {
    return sessionStorage.getItem('userInfo') != null;
  }

  get isActiveEmpresa(): boolean {
    return sessionStorage.getItem('empresaActiva') != null;
  }
}
