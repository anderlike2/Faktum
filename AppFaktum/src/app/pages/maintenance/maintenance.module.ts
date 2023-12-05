import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Error404Component } from './error404/error404.component';
import { MaintenanceRoutingModule } from './routes/maintenance-routing.module';


@NgModule({
  declarations: [Error404Component],
  imports: [
    CommonModule,
    MaintenanceRoutingModule
  ]
})
export class MaintenanceModule { }
