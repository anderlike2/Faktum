import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionProductoRoutingModule } from './routes/gestion-producto-routing.module';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { EditarProductoComponent } from './editar-producto/editar-producto.component';



@NgModule({
  declarations: [EditarProductoComponent],
  imports: [
    CommonModule,
    GestionProductoRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionProductoModule { }