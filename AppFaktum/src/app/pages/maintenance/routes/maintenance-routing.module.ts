import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Error404Component } from '../error404/error404.component';

const maintenanceRoutes: Routes = [
  {
    path: 'error404',
    component: Error404Component,
  },
];

@NgModule({
  imports: [RouterModule.forChild(maintenanceRoutes)],
  exports: [RouterModule],
})
export class MaintenanceRoutingModule {}
