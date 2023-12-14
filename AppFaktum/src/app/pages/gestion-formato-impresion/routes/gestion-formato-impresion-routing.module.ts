import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarFormatoImpresionComponent } from '../editar-formato-impresion/editar-formato-impresion.component';

const formatoImpresionRoutes: Routes = [
  {
    path: 'editar-formato-impresion',
    component: EditarFormatoImpresionComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(formatoImpresionRoutes)],
  exports: [RouterModule],
})
export class GestionFormatoImpresionRoutingModule { }
