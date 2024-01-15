import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarUnidadComponent } from '../editar-unidad/editar-unidad.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const unidadRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_UNIDAD,
    component: EditarUnidadComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(unidadRoutes)],
  exports: [RouterModule],
})
export class GestionUnidadRoutingModule { }
