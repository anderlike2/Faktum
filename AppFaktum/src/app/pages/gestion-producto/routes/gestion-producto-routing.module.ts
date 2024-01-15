import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarProductoComponent } from '../editar-producto/editar-producto.component';
import { DetalleProductoComponent } from '../detalle-producto/detalle-producto.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const productoRoutes: Routes = [
  {
    path: RoutePathEnum.DETALLE_PRODUCTO,
    component: DetalleProductoComponent
  },
  {
    path: RoutePathEnum.EDITAR_PRODUCTO,
    component: EditarProductoComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(productoRoutes)],
  exports: [RouterModule],
})
export class GestionProductoRoutingModule { }
