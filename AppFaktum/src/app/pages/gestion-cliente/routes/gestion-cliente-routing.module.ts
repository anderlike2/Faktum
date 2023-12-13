import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleClienteComponent } from '../detalle-cliente/detalle-cliente.component';
import { EditarClienteComponent } from '../editar-cliente/editar-cliente.component';

const gestionClienteRoutes: Routes = [
  {
    path: 'detalle-cliente',
    component: DetalleClienteComponent
  },
  {
    path: 'editar-cliente',
    component: EditarClienteComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionClienteRoutes)],
  exports: [RouterModule],
})
export class GestionClienteRoutingModule { }
