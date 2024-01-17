import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ErrorHandler, NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { SharedModule } from './theme/shared/shared.module';

import { AppComponent } from './app.component';
import { AdminComponent } from './theme/layout/admin/admin.component';
import { AuthComponent } from './theme/layout/auth/auth.component';
import { NavigationComponent } from './theme/layout/admin/navigation/navigation.component';
import { NavContentComponent } from './theme/layout/admin/navigation/nav-content/nav-content.component';
import { NavGroupComponent } from './theme/layout/admin/navigation/nav-content/nav-group/nav-group.component';
import { NavCollapseComponent } from './theme/layout/admin/navigation/nav-content/nav-collapse/nav-collapse.component';
import { NavItemComponent } from './theme/layout/admin/navigation/nav-content/nav-item/nav-item.component';
import { NavBarComponent } from './theme/layout/admin/nav-bar/nav-bar.component';
import { NavLeftComponent } from './theme/layout/admin/nav-bar/nav-left/nav-left.component';
import { NavSearchComponent } from './theme/layout/admin/nav-bar/nav-left/nav-search/nav-search.component';
import { NavRightComponent } from './theme/layout/admin/nav-bar/nav-right/nav-right.component';
import { ConfigurationComponent } from './theme/layout/admin/configuration/configuration.component';

import { ToggleFullScreenDirective } from './theme/shared/full-screen/toggle-full-screen';

/* Menu Items */
import { NavigationItem } from './theme/layout/admin/navigation/navigation';
import { NgbButtonsModule, NgbDatepickerModule, NgbDropdownModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { LoginComponent } from './pages/login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { InterceptorFaktum } from '../app/shared/interceptor/interceptor-faktum.interceptor';
import { LoaderFaktumInterceptor } from '../app/shared/loader-faktum-interceptor/loader-faktum.interceptor';
import { environment } from 'src/environments/environment';
import { AppErrorHandler } from '../app/core/handlers/error.handler';
import { CambiarEmpresaComponent } from './pages/modals/cambiar-empresa/cambiar-empresa.component';

import { TableModule } from 'primeng/table';
import { CrearSucursalComponent } from './pages/modals/crear-sucursal/crear-sucursal.component';
import { HomeComponent } from './pages/home/home.component';
import { CrearClienteComponent } from './pages/modals/crear-cliente/crear-cliente.component';
import { CrearContratoClienteComponent } from './pages/modals/crear-contrato-cliente/crear-contrato-cliente.component';
import { CrearCentroCostosComponent } from './pages/modals/crear-centro-costos/crear-centro-costos.component';
import { CrearFormatoImpresionComponent } from './pages/modals/crear-formato-impresion/crear-formato-impresion.component';
import { CrearUnidadComponent } from './pages/modals/crear-unidad/crear-unidad.component';
import { CrearListaPrecioComponent } from './pages/modals/crear-lista-precio/crear-lista-precio.component';
import { CrearProductoComponent } from './pages/modals/crear-producto/crear-producto.component';
import { CrearCabeceraFacturaComponent } from './pages/modals/crear-cabecera-factura/crear-cabecera-factura.component';
import { TextMaskModule } from 'angular2-text-mask';
import { NgxMaskModule, IConfig } from 'ngx-mask';
import { MostrarInformacionComponent } from './pages/modals/mostrar-informacion/mostrar-informacion.component';
import { CrearOtroProductoComponent } from './pages/modals/crear-otro-producto/crear-otro-producto.component'
import { TooltipModule } from 'primeng/tooltip';
import { CrearResolucionComponent } from './pages/modals/crear-resolucion/crear-resolucion.component';

export const options: Partial<IConfig> | (() => Partial<IConfig>) = null;

@NgModule({
  declarations: [
    AppComponent,
    AdminComponent,
    AuthComponent,
    NavigationComponent,
    NavContentComponent,
    NavGroupComponent,
    NavCollapseComponent,
    NavItemComponent,
    NavBarComponent,
    NavLeftComponent,
    NavSearchComponent,
    NavRightComponent,
    ConfigurationComponent,
    ToggleFullScreenDirective,
    LoginComponent,
    CambiarEmpresaComponent,
    CrearSucursalComponent,
    HomeComponent,
    CrearClienteComponent,
    CrearContratoClienteComponent,
    CrearCentroCostosComponent,
    CrearFormatoImpresionComponent,
    CrearUnidadComponent,
    CrearListaPrecioComponent,
    CrearProductoComponent,
    CrearCabeceraFacturaComponent,
    MostrarInformacionComponent,
    CrearOtroProductoComponent,
    CrearResolucionComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule,
    NgbDropdownModule,
    NgbTooltipModule,
    NgbButtonsModule,
    NgbDatepickerModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    TableModule,
    TextMaskModule,
    TooltipModule,
    NgxMaskModule.forRoot()
  ],
  exports: [
    TableModule
  ],
  providers: [
    NavigationItem,
    {
      provide: "environment",
      useValue: environment,
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: InterceptorFaktum,
      multi: true
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: LoaderFaktumInterceptor,
      multi: true
    },
    {
      provide: ErrorHandler,
      useClass: AppErrorHandler
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
