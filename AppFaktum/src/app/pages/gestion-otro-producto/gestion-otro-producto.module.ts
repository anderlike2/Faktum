import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionOtroProductoRoutingModule } from './routes/gestion-otro-producto-routing.module';
import { EditarOtroProductoComponent } from './editar-otro-producto/editar-otro-producto.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';

@NgModule({
  declarations: [EditarOtroProductoComponent],
  imports: [
    CommonModule,
    GestionOtroProductoRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionOtroProductoModule { }
