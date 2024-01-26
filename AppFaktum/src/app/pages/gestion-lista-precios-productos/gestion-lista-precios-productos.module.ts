import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DetalleListaPreciosProductosComponent } from './detalle-lista-precios-productos/detalle-lista-precios-productos.component';
import { GestionListaPreciosProductoRoutingModule } from './routes/gestion-lista-precios-producto-routing.module';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { TooltipModule } from 'primeng/tooltip';

@NgModule({
  declarations: [DetalleListaPreciosProductosComponent],
  imports: [
    CommonModule,
    GestionListaPreciosProductoRoutingModule,
    SharedModule,
    NgbModule,
    TableModule,
    TooltipModule
  ]
})
export class GestionListaPreciosProductosModule { }
