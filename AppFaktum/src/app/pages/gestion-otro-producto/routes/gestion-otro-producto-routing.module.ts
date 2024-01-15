import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarOtroProductoComponent } from '../editar-otro-producto/editar-otro-producto.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const unidadRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_OTRO_PRODUCTO,
    component: EditarOtroProductoComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(unidadRoutes)],
  exports: [RouterModule],
})
export class GestionOtroProductoRoutingModule { }
