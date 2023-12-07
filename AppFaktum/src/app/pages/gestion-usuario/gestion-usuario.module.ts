import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionUsuarioRoutingModule } from './routes/gestion-usuario-routing.module';
import { GestionUsuarioComponent } from './gestion-usuario.component';
import { DetalleUsuarioComponent } from './detalle-usuario/detalle-usuario.component';
import { SharedModule } from '../../theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';

@NgModule({
  declarations: [
    GestionUsuarioComponent,
    DetalleUsuarioComponent
  ],
  imports: [
    CommonModule,
    GestionUsuarioRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionUsuarioModule { }
