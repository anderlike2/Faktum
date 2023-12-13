import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleClienteComponent } from '../detalle-cliente/detalle-cliente.component';
import { CrearClienteComponent } from '../crear-cliente/crear-cliente.component';

const gestionClienteRoutes: Routes = [
  {
    path: 'detalle-cliente',
    component: DetalleClienteComponent
  },
  {
    path: 'crear-cliente',
    component: CrearClienteComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionClienteRoutes)],
  exports: [RouterModule],
})
export class GestionClienteRoutingModule { }
