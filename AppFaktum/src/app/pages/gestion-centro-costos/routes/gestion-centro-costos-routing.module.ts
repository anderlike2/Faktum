import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarCentroCostosComponent } from '../editar-centro-costos/editar-centro-costos.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const centroCostosRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_CENTRO_COSTOS,
    component: EditarCentroCostosComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(centroCostosRoutes)],
  exports: [RouterModule],
})
export class GestionCentroCostosRoutingModule { }
