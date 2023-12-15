import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarUnidadComponent } from '../editar-unidad/editar-unidad.component';

const unidadRoutes: Routes = [
  {
    path: 'editar-unidad',
    component: EditarUnidadComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(unidadRoutes)],
  exports: [RouterModule],
})
export class GestionUnidadRoutingModule { }
