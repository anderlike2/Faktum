import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleEmpresaComponent } from '../detalle-empresa/detalle-empresa.component';
import { CrearEmpresaPageComponent } from '../crear-empresa-page/crear-empresa-page.component';

const gestionEmpresaRoutes: Routes = [
  {
    path: 'detalle-empresa',
    component: DetalleEmpresaComponent
  },
  {
    path: 'crear-empresa',
    component: CrearEmpresaPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionEmpresaRoutes)],
  exports: [RouterModule],
})
export class GestionEmpresaRoutingModule {}
