import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleClienteComponent } from '../detalle-cliente/detalle-cliente.component';

const gestionClienteRoutes: Routes = [
  {
    path: 'detalle-cliente',
    component: DetalleClienteComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionClienteRoutes)],
  exports: [RouterModule],
})
export class GestionClienteRoutingModule { }
