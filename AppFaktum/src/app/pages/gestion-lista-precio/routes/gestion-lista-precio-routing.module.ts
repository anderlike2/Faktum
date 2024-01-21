import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarListaPrecioComponent } from '../editar-lista-precio/editar-lista-precio.component';
import { RoutePathEnum } from 'src/app/models/routes-path.model';
import { EditGeneralGuard } from 'src/app/shared/edit-general-guard/edit-general.guard';

const listaPrecioRoutes: Routes = [
  {
    path: RoutePathEnum.EDITAR_LISTA_PRECIO,
    component: EditarListaPrecioComponent,
    canActivate: [EditGeneralGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(listaPrecioRoutes)],
  exports: [RouterModule],
})
export class GestionListaPrecioRoutingModule { }
