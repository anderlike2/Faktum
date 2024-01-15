import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleClienteComponent } from '../detalle-cliente/detalle-cliente.component';
import { EditarClienteComponent } from '../editar-cliente/editar-cliente.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const gestionClienteRoutes: Routes = [
  {
    path: RoutePathEnum.DETALLE_CLIENTE,
    component: DetalleClienteComponent
  },
  {
    path: RoutePathEnum.EDITAR_CLIENTE,
    component: EditarClienteComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionClienteRoutes)],
  exports: [RouterModule],
})
export class GestionClienteRoutingModule { }
