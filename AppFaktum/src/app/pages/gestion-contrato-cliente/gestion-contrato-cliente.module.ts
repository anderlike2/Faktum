import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EditarContratoClienteComponent } from './editar-contrato-cliente/editar-contrato-cliente.component';
import { GestionContratoClienteRoutingModule } from './routes/gestion-contrato-cliente-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/theme/shared/shared.module';



@NgModule({
  declarations: [EditarContratoClienteComponent],
  imports: [
    CommonModule,
    GestionContratoClienteRoutingModule,
    SharedModule,
    NgbModule,
    TableModule
  ]
})
export class GestionContratoClienteModule { }
