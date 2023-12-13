import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionSucursalRoutingModule } from './routes/gestion-sucursal-routing.module';
import { DetalleSucursalComponent } from './detalle-sucursal/detalle-sucursal.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { EditarSucursalComponent } from './editar-sucursal/editar-sucursal.component';
import { TableModule } from 'primeng/table';



@NgModule({
  declarations: [DetalleSucursalComponent, EditarSucursalComponent],
  imports: [
    CommonModule,
    GestionSucursalRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionSucursalModule { }
