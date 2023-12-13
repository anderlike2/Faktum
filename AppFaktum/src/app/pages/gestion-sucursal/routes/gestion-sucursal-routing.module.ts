import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleSucursalComponent } from '../detalle-sucursal/detalle-sucursal.component';
import { EditarSucursalComponent } from '../editar-sucursal/editar-sucursal.component';
import { EditSucursalGuard } from 'src/app/shared/edit-sucursal-guard/edit-sucursal.guard';

const gestionSucursalRoutes: Routes = [
  {
    path: 'detalle-sucursal',
    component: DetalleSucursalComponent
  },
  {
    path: 'editar-sucursal',
    component: EditarSucursalComponent,
    canActivate: [EditSucursalGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(gestionSucursalRoutes)],
  exports: [RouterModule],
})
export class GestionSucursalRoutingModule {}
