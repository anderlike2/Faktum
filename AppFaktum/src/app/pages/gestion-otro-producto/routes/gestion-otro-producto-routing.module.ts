import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarOtroProductoComponent } from '../editar-otro-producto/editar-otro-producto.component';

const unidadRoutes: Routes = [
  {
    path: 'editar-otro-producto',
    component: EditarOtroProductoComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(unidadRoutes)],
  exports: [RouterModule],
})
export class GestionOtroProductoRoutingModule { }
