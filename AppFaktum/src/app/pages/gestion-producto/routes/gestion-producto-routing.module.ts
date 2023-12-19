import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarProductoComponent } from '../editar-producto/editar-producto.component';

const productoRoutes: Routes = [
  {
    path: 'editar-producto',
    component: EditarProductoComponent,
  }
];

@NgModule({
  imports: [RouterModule.forChild(productoRoutes)],
  exports: [RouterModule],
})
export class GestionProductoRoutingModule { }
