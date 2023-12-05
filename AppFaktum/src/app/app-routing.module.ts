import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './theme/layout/admin/admin.component';
import {AuthComponent} from './theme/layout/auth/auth.component';
import { LoginComponent } from './pages/login/login.component';
import { LoginGuard } from './shared/login-guard/login.guard'
import { LogoutGuard } from './shared/logout-guard/logout.guard';
import { NoEmpresaGuard } from './shared/no-empresa/no-empresa.guard';

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
        redirectTo: 'sample-page',
        canActivate: [LoginGuard],
        pathMatch: 'full'
      },
      {
        path: 'gestion-empresa',
        loadChildren: () => import('./pages/gestion-empresa/gestion-empresa.module').then(m => m.GestionEmpresaModule),
        canActivate: [LoginGuard]
      },
      {
        path: 'sample-page',
        loadChildren: () => import('./demo/pages/sample-page/sample-page.module').then(module => module.SamplePageModule),
        canActivate: [LoginGuard],
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
