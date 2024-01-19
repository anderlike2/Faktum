import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionResolucionSucursalRoutingModule } from './routes/gestion-resolucion-sucursal-routing.module';
import { EditarResolucionSucursalComponent } from './editar-resolucion-sucursal/editar-resolucion-sucursal.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { TooltipModule } from 'primeng/tooltip';

@NgModule({
  declarations: [EditarResolucionSucursalComponent],
  imports: [
    CommonModule,
    GestionResolucionSucursalRoutingModule,
    SharedModule,
    NgbModule,
    TableModule,
    TooltipModule
  ]
})
export class GestionResolucionSucursalModule { }
