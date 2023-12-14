import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarCentroCostosComponent } from '../editar-centro-costos/editar-centro-costos.component';

const centroCostosRoutes: Routes = [
  {
    path: 'editar-centro-costos',
    component: EditarCentroCostosComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(centroCostosRoutes)],
  exports: [RouterModule],
})
export class GestionCentroCostosRoutingModule { }
