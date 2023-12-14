import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionCentroCostosRoutingModule } from './routes/gestion-centro-costos-routing.module';
import { EditarCentroCostosComponent } from './editar-centro-costos/editar-centro-costos.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';



@NgModule({
  declarations: [EditarCentroCostosComponent],
  imports: [
    CommonModule,
    GestionCentroCostosRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionCentroCostosModule { }
