import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarContratoClienteComponent } from '../editar-contrato-cliente/editar-contrato-cliente.component';

const contratoClienteRoutes: Routes = [
  {
    path: 'editar-contrato-cliente',
    component: EditarContratoClienteComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(contratoClienteRoutes)],
  exports: [RouterModule],
})
export class GestionContratoClienteRoutingModule { }
