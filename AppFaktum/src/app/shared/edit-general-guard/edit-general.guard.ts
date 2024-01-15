import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { RoutePathEnum } from 'src/app/models/routes-path.model';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Injectable({
  providedIn: 'root'
})
export class EditGeneralGuard implements CanActivate {
  private subscription: Subscription;

  private pathReturnMap: { [key: string]: string } = {
    [RoutePathEnum.EDITAR_CENTRO_COSTOS]: '/' + [RoutePathEnum.GESTION_EMPRESA, RoutePathEnum.CENTRO_COSTOS].join('/'),
    [RoutePathEnum.EDITAR_FORMATO_IMPRESION]: '/' + [RoutePathEnum.GESTION_EMPRESA, RoutePathEnum.FORMATOS_IMPRESION].join('/'),
    [RoutePathEnum.EDITAR_UNIDAD]: '/' + [RoutePathEnum.GESTION_EMPRESA, RoutePathEnum.UNIDAD].join('/'),
    [RoutePathEnum.EDITAR_OTRO_PRODUCTO]: '/' + [RoutePathEnum.GESTION_EMPRESA, RoutePathEnum.OTROS_PRODUCTOS].join('/'),
    [RoutePathEnum.EDITAR_CLIENTE]: '/' + [RoutePathEnum.GESTION_CLIENTE, RoutePathEnum.DETALLE_CLIENTE].join('/'),
    [RoutePathEnum.EDITAR_CONTRATO_CLIENTE]: '/' + [RoutePathEnum.GESTION_CLIENTE, RoutePathEnum.DETALLE_CLIENTE].join('/'),
    [RoutePathEnum.EDITAR_PRODUCTO]: '/' + [RoutePathEnum.GESTION_PRODUCTO, RoutePathEnum.DETALLE_PRODUCTO].join('/'),
  };


  constructor(
    private sharedService: SharedService,
    private router: Router
  ) {}


  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      return new Promise(resolve => {
        this.subscription = this.sharedService.editarGeneralDataListener$.subscribe(general => {
          if (general) {
            resolve(true);
          } else {
            const path = next.routeConfig.path;
            const url = this.pathReturnMap[path] ?? '/';
            this.router.navigate([url]);
            resolve(false);
          }
        });
      });
  }

  destroy() {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }

}
