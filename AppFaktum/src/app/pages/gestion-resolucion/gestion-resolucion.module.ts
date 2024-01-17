import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionResolucionRoutingModule } from './routes/gestion-resolucion-routing.module';
import { EditarResolucionComponent } from './editar-resolucion/editar-resolucion.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';

@NgModule({
  declarations: [EditarResolucionComponent],
  imports: [
    CommonModule,
    GestionResolucionRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionResolucionModule { }
