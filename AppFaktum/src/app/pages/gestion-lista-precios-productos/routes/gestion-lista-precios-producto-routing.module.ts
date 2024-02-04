import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleListaPreciosProductosComponent } from '../detalle-lista-precios-productos/detalle-lista-precios-productos.component';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const listaPrecioProductoRoutes: Routes = [
  {
    path: RoutePathEnum.DETALLE_LISTA_PRECIOS_PRODUCTO,
    component: DetalleListaPreciosProductosComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(listaPrecioProductoRoutes)],
  exports: [RouterModule],
})
export class GestionListaPreciosProductoRoutingModule { }
