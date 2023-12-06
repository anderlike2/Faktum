import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionSucursalRoutingModule } from './routes/gestion-sucursal-routing.module';
import { DetalleSucursalComponent } from './detalle-sucursal/detalle-sucursal.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SharedModule } from 'src/app/theme/shared/shared.module';



@NgModule({
  declarations: [DetalleSucursalComponent],
  imports: [
    CommonModule,
    GestionSucursalRoutingModule,
    SharedModule,
    NgbModule
  ]
})
export class GestionSucursalModule { }
