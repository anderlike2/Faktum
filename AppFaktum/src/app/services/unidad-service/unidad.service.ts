import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { IUnidad } from 'src/app/models/unidad.model';

@Injectable({
  providedIn: 'root'
})
export class UnidadService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerUnidadesPorEmpresaId(empresaId: number): Observable<IUnidad[]> {
    const url = `${this.environment.faktumUrl}/Unidad/ConsultarUnidadesEmpresa?idEmpresa=${empresaId}`;
    return this.httpClient.get<IResponse<IUnidad[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IUnidad[]
      )
    );
  }

  obtenerUnidadPorId(unidadId: number): Observable<IResponse<IUnidad>> {
    const url = `${this.environment.faktumUrl}/Unidad/ConsultarUnidadId?idUnidad=${unidadId}`;
    return this.httpClient.get<IResponse<IUnidad>>(
      url
    )
  }

  crearUnidad(data: IUnidad): Observable<any> {
    const url = `${this.environment.faktumUrl}/Unidad/CrearUnidad`;
    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarUnidad(data: IUnidad): Observable<any> {
    const url = `${this.environment.faktumUrl}/Unidad/ActualizarUnidad`;
    return this.httpClient.post(
      url,
      data
    )
  }
}
