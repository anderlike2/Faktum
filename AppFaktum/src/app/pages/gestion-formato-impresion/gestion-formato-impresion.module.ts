import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionFormatoImpresionRoutingModule } from './routes/gestion-formato-impresion-routing.module';
import { EditarFormatoImpresionComponent } from './editar-formato-impresion/editar-formato-impresion.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { TooltipModule } from 'primeng/tooltip';

@NgModule({
  declarations: [EditarFormatoImpresionComponent],
  imports: [
    CommonModule,
    GestionFormatoImpresionRoutingModule,
    SharedModule,
    NgbModule,
    TableModule,
    TooltipModule
  ]
})
export class GestionFormatoImpresionModule { }
