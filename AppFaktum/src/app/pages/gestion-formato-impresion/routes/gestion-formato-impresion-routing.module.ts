import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarFormatoImpresionComponent } from '../editar-formato-impresion/editar-formato-impresion.component';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';
import { RoutePathEnum } from 'src/app/models/routes-path.model';

const formatoImpresionRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_FORMATO_IMPRESION,
    component: EditarFormatoImpresionComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(formatoImpresionRoutes)],
  exports: [RouterModule],
})
export class GestionFormatoImpresionRoutingModule { }
