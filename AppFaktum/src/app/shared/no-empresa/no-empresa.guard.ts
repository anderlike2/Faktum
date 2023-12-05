import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { SessionService } from 'src/app/services/session-service/session.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Injectable({
  providedIn: 'root'
})
export class NoEmpresaGuard implements CanActivate {

  constructor(
    private sessionService: SessionService,
    private storageService: StorageService,
  ) {}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {

    return true;
  }

}
