import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarListaPrecioComponent } from '../editar-lista-precio/editar-lista-precio.component';

const listaPrecioRoutes: Routes = [
  {
    path: 'editar-lista-precio',
    component: EditarListaPrecioComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(listaPrecioRoutes)],
  exports: [RouterModule],
})
export class GestionListaPrecioRoutingModule { }
