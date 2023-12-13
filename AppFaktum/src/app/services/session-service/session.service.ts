import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class SessionService {

  constructor(
    private router: Router
  ) { }

  get isLogged(): boolean {
    return sessionStorage.getItem('userInfo') != null;
  }

  get isActiveEmpresa(): boolean {
    return sessionStorage.getItem('empresaActiva') != null;
  }

  logout(): void {
    sessionStorage.clear();
    this.router.navigateByUrl('/inicio-sesion');
  }
}
