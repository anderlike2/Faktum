import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { IResolucion } from 'src/app/models/resolucion.model';

@Injectable({
  providedIn: 'root'
})
export class ResolucionService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerResolucionesPorEmpresaId(empresaId: number): Observable<IResolucion[]> {
    const url = `${this.environment.faktumUrl}/Resolucion/ConsultarResolucionesEmpresa?idEmpresa=${empresaId}`;
    return this.httpClient.get<IResponse<IResolucion[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IResolucion[]
      )
    );
  }

  obtenerResolucionPorId(resolucionId: number): Observable<IResponse<IResolucion>> {
    const url = `${this.environment.faktumUrl}/Resolucion/ConsultarResolucionId?idResolucion=${resolucionId}`;
    return this.httpClient.get<IResponse<IResolucion>>(
      url
    )
  }

  crearResolucion(data: IResolucion): Observable<any> {
    const url = `${this.environment.faktumUrl}/Resolucion/CrearResolucion`;
    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarResolucion(data: IResolucion): Observable<any> {
    const url = `${this.environment.faktumUrl}/Resolucion/ActualizarResolucion`;
    return this.httpClient.post(
      url,
      data
    )
  }

  obtenerResolucionesPorSucursalId(sucursalId: number): Observable<IResolucion[]> {
    const url = `${this.environment.faktumUrl}/Resolucion/ConsultarResolucionesSucursal?idSucursal=${sucursalId}`;
    return this.httpClient.get<IResponse<IResolucion[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IResolucion[]
      )
    );
  }
}
