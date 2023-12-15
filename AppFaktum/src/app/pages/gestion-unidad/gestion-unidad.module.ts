import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionUnidadRoutingModule } from './routes/gestion-unidad-routing.module';
import { EditarUnidadComponent } from './editar-unidad/editar-unidad.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';

@NgModule({
  declarations: [EditarUnidadComponent],
  imports: [
    CommonModule,
    GestionUnidadRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionUnidadModule { }
