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
