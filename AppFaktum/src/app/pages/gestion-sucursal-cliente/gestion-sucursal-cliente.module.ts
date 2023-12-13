import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionSucursalClienteRoutingModule } from './routes/gestion-sucursal-cliente-routing.module';
import { GestionSucursalClienteComponent } from './gestion-sucursal-cliente.component';
import { DetalleSucursalClienteComponent } from './detalle-sucursal-cliente/detalle-sucursal-cliente.component';
import { EditarSucursalClienteComponent } from './editar-sucursal-cliente/editar-sucursal-cliente.component';
import { SharedModule } from '../../theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';

@NgModule({
  declarations: [
    GestionSucursalClienteComponent,
    DetalleSucursalClienteComponent,
    EditarSucursalClienteComponent
  ],
  imports: [
    CommonModule,
    GestionSucursalClienteRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionSucursalClienteModule { }
