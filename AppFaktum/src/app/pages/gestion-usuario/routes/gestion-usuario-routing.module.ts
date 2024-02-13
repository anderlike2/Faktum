import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleUsuarioComponent } from '../detalle-usuario/detalle-usuario.component';
import { HasRoleGuard } from 'src/app/shared/has-role-guard/has-role.guard';

const gestionUsuarioRoutes: Routes = [
  {
    path: 'detalle-usuario',
    component: DetalleUsuarioComponent,
    canActivate: [HasRoleGuard],
    data: {
      allowedRoles: ['ROL_ADMINISTRADOR']
    }
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionUsuarioRoutes)],
  exports: [RouterModule],
})
export class GestionUsuarioRoutingModule { }
