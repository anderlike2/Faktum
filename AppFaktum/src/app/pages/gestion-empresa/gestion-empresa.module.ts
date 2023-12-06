import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionEmpresaRoutingModule } from './routes/gestion-empresa-routing.module';
import { GestionEmpresaComponent } from './gestion-empresa.component';
import { DetalleEmpresaComponent } from './detalle-empresa/detalle-empresa.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [
    GestionEmpresaComponent,
    DetalleEmpresaComponent
  ],
  imports: [
    CommonModule,
    GestionEmpresaRoutingModule,
    SharedModule,
    NgbModule
  ]
})
export class GestionEmpresaModule { }
