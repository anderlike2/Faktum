import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleUsuarioComponent } from '../detalle-usuario/detalle-usuario.component';

const gestionUsuarioRoutes: Routes = [
  {
    path: 'detalle-usuario',
    component: DetalleUsuarioComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionUsuarioRoutes)],
  exports: [RouterModule],
})
export class GestionUsuarioRoutingModule { }
