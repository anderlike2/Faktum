import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarResolucionSucursalComponent } from '../editar-resolucion-sucursal/editar-resolucion-sucursal.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const resolucionSucursalRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_RESOLUCION_SUCURSAL,
    component: EditarResolucionSucursalComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(resolucionSucursalRoutes)],
  exports: [RouterModule],
})
export class GestionResolucionSucursalRoutingModule { }
