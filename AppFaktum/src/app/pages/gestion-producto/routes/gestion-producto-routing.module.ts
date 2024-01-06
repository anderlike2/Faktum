import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarProductoComponent } from '../editar-producto/editar-producto.component';
import { DetalleProductoComponent } from '../detalle-producto/detalle-producto.component';

const productoRoutes: Routes = [
  {
    path: 'detalle-producto',
    component: DetalleProductoComponent
  },
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
