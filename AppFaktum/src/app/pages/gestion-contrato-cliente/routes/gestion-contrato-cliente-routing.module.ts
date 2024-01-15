import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarContratoClienteComponent } from '../editar-contrato-cliente/editar-contrato-cliente.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const contratoClienteRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_CONTRATO_CLIENTE,
    component: EditarContratoClienteComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(contratoClienteRoutes)],
  exports: [RouterModule],
})
export class GestionContratoClienteRoutingModule { }
