import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IClienteEmpresa } from 'src/app/models/cliente-empresa.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IEnvironment } from 'src/app/models/environment.model';
import { ISucursalEmpresa } from 'src/app/models/sucursal-empresa.model';
import { ISucursal } from 'src/app/models/sucursal.model';

@Injectable({
  providedIn: 'root'
})
export class DetalleEmpresaService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }


  actualizarEmpresa(data: IEmpresa): Observable<any> {

    const url = `${this.environment.faktumUrl}/Empresa/ActualizarEmpresa`;

    return this.httpClient.post(
      url,
      data
    );
  }

  obtenerInformacionSucursalesEmpresaId(idEmpresa: number): Observable<ISucursalEmpresa[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Sucursal/ConsultarSucursalesEmpresa?idEmpresa=${idEmpresa}`
    )
    .pipe(
      map((response) =>
        response.data as ISucursalEmpresa[]
      )
    );
  }

  obtenerInformacionClientesEmpresaId(idEmpresa: number): Observable<IClienteEmpresa[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Cliente/ConsultarClientesEmpresa?idEmpresa=${idEmpresa}`
    )
    .pipe(
      map((response) =>
        response.data as IClienteEmpresa[]
      )
    );
  }

  crearSucursal(data: ISucursal) {
    const url = `${this.environment.faktumUrl}/Sucursal/CrearSucursal`;

    return this.httpClient.post(
      url,
      data
    );
  }

  actualizarSucursal(data: ISucursal) {
    const url = `${this.environment.faktumUrl}/Sucursal/ActualizarSucursal`;

    return this.httpClient.post(
      url,
      data
    );
  }
}
