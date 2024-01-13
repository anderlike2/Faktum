import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './theme/layout/admin/admin.component';
import {AuthComponent} from './theme/layout/auth/auth.component';
import { LoginComponent } from './pages/login/login.component';
import { LoginGuard } from './shared/login-guard/login.guard'
import { LogoutGuard } from './shared/logout-guard/logout.guard';
import { NoEmpresaGuard } from './shared/no-empresa/no-empresa.guard';
import { HomeComponent } from './pages/home/home.component';

const routes: Routes = [
  {
    path: 'inicio-sesion',
    component: LoginComponent,
    canActivate: [LogoutGuard]
  },
  {
    path: 'error',
    loadChildren: () => import('../app/pages/maintenance/maintenance.module').then(module => module.MaintenanceModule)
  },
  {
    path: '',
    component: AdminComponent,
    canActivate: [NoEmpresaGuard],
    children: [
      {
        path: '',
        redirectTo: 'home',
        canActivate: [LoginGuard],
        pathMatch: 'full'
      },
      {
        path: 'gestion-empresa',
        loadChildren: () => import('./pages/gestion-empresa/gestion-empresa.module').then(m => m.GestionEmpresaModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-cliente',
        loadChildren: () => import('./pages/gestion-cliente/gestion-cliente.module').then(m => m.GestionClienteModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-sucursal',
        loadChildren: () => import('./pages/gestion-sucursal/gestion-sucursal.module').then(m => m.GestionSucursalModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-usuario',
        loadChildren: () => import('./pages/gestion-usuario/gestion-usuario.module').then(m => m.GestionUsuarioModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-contrato-cliente',
        loadChildren: () => import('./pages/gestion-contrato-cliente/gestion-contrato-cliente.module').then(m => m.GestionContratoClienteModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-centro-costos',
        loadChildren: () => import('./pages/gestion-centro-costos/gestion-centro-costos.module').then(m => m.GestionCentroCostosModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-formato-impresion',
        loadChildren: () => import('./pages/gestion-formato-impresion/gestion-formato-impresion.module').then(m => m.GestionFormatoImpresionModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-unidad',
        loadChildren: () => import('./pages/gestion-unidad/gestion-unidad.module').then(m => m.GestionUnidadModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-lista-precio',
        loadChildren: () => import('./pages/gestion-lista-precio/gestion-lista-precio.module').then(m => m.GestionListaPrecioModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-producto',
        loadChildren: () => import('./pages/gestion-producto/gestion-producto.module').then(m => m.GestionProductoModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'factura',
        loadChildren: () => import('./pages/gestion-factura/gestion-factura.module').then(m => m.GestionFacturaModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'gestion-otro-producto',
        loadChildren: () => import('./pages/gestion-otro-producto/gestion-otro-producto.module').then(m => m.GestionOtroProductoModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'home',
        component: HomeComponent,
        canActivate: [LoginGuard]
      }
    ]
  },
  // {
  //   path: '',
  //   component: AuthComponent,
  //   children: []
  // }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
