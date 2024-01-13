import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionEmpresaRoutingModule } from './routes/gestion-empresa-routing.module';
import { GestionEmpresaComponent } from './gestion-empresa.component';
import { DetalleEmpresaComponent } from './detalle-empresa/detalle-empresa.component';
import { SharedModule } from 'src/app/theme/shared/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng-lts/table';
import { CrearEmpresaPageComponent } from './crear-empresa-page/crear-empresa-page.component';
import { NgxFileDropModule } from 'ngx-file-drop';
import { CentroCostosComponent } from './centro-costos/centro-costos.component';
import { FormatosImpresionComponent } from './formatos-impresion/formatos-impresion.component';
import { UnidadesComponent } from './unidades/unidades.component';
import { OtrosProductosComponent } from './otros-productos/otros-productos.component';

@NgModule({
  declarations: [
    GestionEmpresaComponent,
    DetalleEmpresaComponent,
    CrearEmpresaPageComponent,
    CentroCostosComponent,
    FormatosImpresionComponent,
    UnidadesComponent,
    OtrosProductosComponent
  ],
  imports: [
    CommonModule,
    GestionEmpresaRoutingModule,
    SharedModule,
    NgbModule,
    TableModule,
    NgxFileDropModule
  ]
})
export class GestionEmpresaModule { }
