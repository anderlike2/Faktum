import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionListaPrecioRoutingModule } from './routes/gestion-lista-precio-routing.module';
import { EditarListaPrecioComponent } from './editar-lista-precio/editar-lista-precio.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';


@NgModule({
  declarations: [EditarListaPrecioComponent],
  imports: [
    CommonModule,
    GestionListaPrecioRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionListaPrecioModule { }
