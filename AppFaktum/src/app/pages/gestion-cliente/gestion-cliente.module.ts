import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionClienteRoutingModule } from './routes/gestion-cliente-routing.module';
import { GestionClienteComponent } from './gestion-cliente.component';
import { DetalleClienteComponent } from './detalle-cliente/detalle-cliente.component';
import { CrearClienteComponent } from './crear-cliente/crear-cliente.component';
import { SharedModule } from '../../theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';


@NgModule({
  declarations: [
    GestionClienteComponent,
    DetalleClienteComponent,
    CrearClienteComponent
  ],
  imports: [
    CommonModule,
    GestionClienteRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionClienteModule { }
