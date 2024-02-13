import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StorageService {
  localStorageKey!: string;

  private userInfo = new BehaviorSubject<any>(undefined);
  userInfo$ = this.userInfo.asObservable();

  constructor(
    private router: Router,
  ) { }

  setLocalStorageKey(key: string): void {
    this.localStorageKey = key;
  }

  setUserStorage(userInfo: any | any): void {
    this.loadUserInfo(userInfo);

    sessionStorage.setItem('userInfo', JSON.stringify(userInfo));
  }

  setEmpresaStorage(empresaInfo: any): void {
    sessionStorage.setItem('empresaInfo', JSON.stringify(empresaInfo));
  }

  getEmpresaStorage(): any[] {
    const empresas = sessionStorage.getItem('empresaInfo');
    if (empresas) {
      return JSON.parse(empresas);
    } else {
      return [];
    }
  }

  getUsuarioStorage(): any {
    const usuario = sessionStorage.getItem('userInfo');
    if (usuario) {
      return JSON.parse(usuario);
    } else {
      return {};
    }
  }

  setUserRolesStorage(rolesInfo: any): void {
    sessionStorage.setItem('rolesInfo', JSON.stringify(rolesInfo));
  }

  getUserRolesStorage(): any {
    const roles = sessionStorage.getItem('rolesInfo');
    if (roles) {
      return JSON.parse(roles);
    } else {
      return [];
    }
  }

  clearUserStorage(): void {
    sessionStorage.removeItem('userInfo');
    this.loadUserInfo(undefined);
  }

  private loadUserInfo(userInfo?: any): void {
    this.userInfo.next(userInfo);
  }

  setEmpresaActivaStorage(empresaInfo: any): void {
    sessionStorage.setItem('empresaActiva', JSON.stringify(empresaInfo));
  }

  getEmpresaActivaStorage(): any {
    const empresa = sessionStorage.getItem('empresaActiva');
    if (empresa) {
      return JSON.parse(empresa);
    } else {
      return {};
    }
  }

  logout(): void {
    localStorage.clear();
    this.router.navigateByUrl('/inicio-sesion');
  }
}
