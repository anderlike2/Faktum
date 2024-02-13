import { Injectable, inject } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Injectable({
  providedIn: 'root'
})
export class HasRoleGuard implements CanActivate {

  constructor(
    private storageService: StorageService,
    private router: Router
    ) {}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    return this.hasRole(next) || this.router.createUrlTree(['/']);
  }

  private hasRole(route: ActivatedRouteSnapshot) {
    const allowedRoles = route.data?.['allowedRoles'];

    const roles = this.storageService.getUserRolesStorage();

    return roles.some(rol => allowedRoles.includes(rol.rolCodigo));
  }

}

export function hasRole(allowedRoles: any[]) {
  return () => {
    const roles = inject(StorageService).getUserRolesStorage();

    return roles.some(rol => allowedRoles.includes(rol.rolCodigo));
  }
}
