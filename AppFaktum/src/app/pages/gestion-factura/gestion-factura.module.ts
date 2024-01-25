import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionFacturaRoutingModule } from './routes/gestion-factura-routing.module';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbDateParserFormatter, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { CrearFacturaComponent } from './crear-factura/crear-factura.component';
import { TooltipModule } from 'primeng/tooltip';

@NgModule({
  declarations: [CrearFacturaComponent],
  imports: [
    CommonModule,
    GestionFacturaRoutingModule,
    SharedModule,
    NgbModule,
    TableModule,
    TooltipModule
  ]
})
export class GestionFacturaModule { }
