import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionFacturaRoutingModule } from './routes/gestion-factura-routing.module';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { CrearFacturaComponent } from './crear-factura/crear-factura.component';



@NgModule({
  declarations: [CrearFacturaComponent],
  imports: [
    CommonModule,
    GestionFacturaRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionFacturaModule { }
