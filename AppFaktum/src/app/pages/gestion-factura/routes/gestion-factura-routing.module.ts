import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CrearFacturaComponent } from '../crear-factura/crear-factura.component';

const gestionFacturaRoutes: Routes = [
  {
    path: 'crear-factura',
    component: CrearFacturaComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionFacturaRoutes)],
  exports: [RouterModule],
})
export class GestionFacturaRoutingModule {}
