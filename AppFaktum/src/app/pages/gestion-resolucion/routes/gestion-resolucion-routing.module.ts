import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarResolucionComponent } from '../editar-resolucion/editar-resolucion.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const resolucionRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_RESOLUCION,
    component: EditarResolucionComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(resolucionRoutes)],
  exports: [RouterModule],
})
export class GestionResolucionRoutingModule { }