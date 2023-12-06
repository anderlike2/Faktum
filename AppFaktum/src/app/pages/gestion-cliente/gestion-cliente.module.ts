import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionClienteRoutingModule } from './routes/gestion-cliente-routing.module';
import { GestionClienteComponent } from './gestion-cliente.component';
import { DetalleClienteComponent } from './detalle-cliente/detalle-cliente.component';
import { SharedModule } from '../../theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [
    GestionClienteComponent,
    DetalleClienteComponent
  ],
  imports: [
    CommonModule,
    GestionClienteRoutingModule,
    SharedModule,
    NgbModule
  ]
})
export class GestionClienteModule { }
