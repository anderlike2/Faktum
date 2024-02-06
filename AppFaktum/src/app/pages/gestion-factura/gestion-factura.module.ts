import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionFacturaRoutingModule } from './routes/gestion-factura-routing.module';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbDateParserFormatter, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { CrearFacturaComponent } from './crear-factura/crear-factura.component';
import { TooltipModule } from 'primeng/tooltip';
import { IConfig, NgxMaskModule } from 'ngx-mask';
import { PercentInputDirective } from 'src/app/shared/percent-input-directive/percent-input.directive';

export const options: Partial<IConfig> | (() => Partial<IConfig>) = null;

@NgModule({
  declarations: [
    CrearFacturaComponent
  ],
  imports: [
    CommonModule,
    GestionFacturaRoutingModule,
    SharedModule,
    NgbModule,
    TableModule,
    TooltipModule,
    NgxMaskModule.forRoot()
  ]
})
export class GestionFacturaModule { }
