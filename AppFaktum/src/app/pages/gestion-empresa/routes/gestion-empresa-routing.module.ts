import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetalleEmpresaComponent } from '../detalle-empresa/detalle-empresa.component';
import { CrearEmpresaPageComponent } from '../crear-empresa-page/crear-empresa-page.component';
import { CentroCostosComponent } from '../centro-costos/centro-costos.component';
import { FormatosImpresionComponent } from '../formatos-impresion/formatos-impresion.component';
import { UnidadesComponent } from '../unidades/unidades.component';
import { OtrosProductosComponent } from '../otros-productos/otros-productos.component';
import { ResolucionesComponent } from '../resoluciones/resoluciones.component';
import { ListasPreciosComponent } from '../listas-precios/listas-precios.component';
import { HasRoleGuard } from 'src/app/shared/has-role-guard/has-role.guard';

const gestionEmpresaRoutes: Routes = [
  {
    path: 'detalle-empresa',
    component: DetalleEmpresaComponent
  },
  {
    path: 'crear-empresa',
    component: CrearEmpresaPageComponent,
    canActivate: [HasRoleGuard],
    data: {
      allowedRoles: ['ROL_ADMINISTRADOR']
    }
  },
  {
    path: 'centro-costos',
    component: CentroCostosComponent
  },
  {
    path: 'formatos-impresion',
    component: FormatosImpresionComponent
  },
  {
    path: 'unidad',
    component: UnidadesComponent
  },
  {
    path: 'otros-productos',
    component: OtrosProductosComponent
  },
  {
    path: 'resoluciones',
    component: ResolucionesComponent
  },
  {
    path: 'listas-precios',
    component: ListasPreciosComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(gestionEmpresaRoutes)],
  exports: [RouterModule],
})
export class GestionEmpresaRoutingModule {}
