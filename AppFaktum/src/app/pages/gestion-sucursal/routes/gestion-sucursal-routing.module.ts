import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleSucursalComponent } from '../detalle-sucursal/detalle-sucursal.component';

const gestionSucursalRoutes: Routes = [
  {
    path: 'detalle-sucursal',
    component: DetalleSucursalComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionSucursalRoutes)],
  exports: [RouterModule],
})
export class GestionSucursalRoutingModule {}
