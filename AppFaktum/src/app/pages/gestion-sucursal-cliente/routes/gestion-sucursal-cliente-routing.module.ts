import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleSucursalClienteComponent } from '../detalle-sucursal-cliente/detalle-sucursal-cliente.component';
import { EditarSucursalClienteComponent } from '../editar-sucursal-cliente/editar-sucursal-cliente.component';

const gestionSucursalClienteRoutes: Routes = [
  {
    path: 'detalle-sucursal-cliente',
    component: DetalleSucursalClienteComponent
  },
  {
    path: 'editar-sucursal-cliente',
    component: EditarSucursalClienteComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionSucursalClienteRoutes)],
  exports: [RouterModule],
})
export class GestionSucursalClienteRoutingModule { }
