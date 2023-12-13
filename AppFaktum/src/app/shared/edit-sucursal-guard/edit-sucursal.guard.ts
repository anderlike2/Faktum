import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Injectable({
  providedIn: 'root'
})
export class EditSucursalGuard implements CanActivate {
  private subscription: Subscription;

  constructor(
    private sharedService: SharedService,
    private router: Router
  ) {}

  canActivate(): Observable<boolean> | Promise<boolean> | boolean {
    return new Promise(resolve => {
      this.subscription = this.sharedService.sucursalEmpresaDataListener$.subscribe(sucursal => {
        console.log(sucursal);
        if (sucursal) {
          resolve(true);
        } else {
          this.router.navigate(['/gestion-sucursal/detalle-sucursal']);
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
