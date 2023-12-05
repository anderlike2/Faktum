import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleEmpresaComponent } from '../detalle-empresa/detalle-empresa.component';

const gestionEmpresaRoutes: Routes = [
  {
    path: 'detalle-empresa',
    component: DetalleEmpresaComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionEmpresaRoutes)],
  exports: [RouterModule],
})
export class GestionEmpresaRoutingModule {}
