import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ICentroCostos } from 'src/app/models/centro-costos.model';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';

@Injectable({
  providedIn: 'root'
})
export class CentroCostosService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerCentroCostosPorEmpresaId(empresaID: number): Observable<ICentroCostos[]> {
    const url = `${this.environment.faktumUrl}/CentroCosto/ConsultarCentrosCostoEmpresa?idEmpresa=${empresaID}`;
    return this.httpClient.get<IResponse<ICentroCostos[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as ICentroCostos[]
      )
    );
  }

  obtenerCentroCostosPorId(centroCostosID: number): Observable<IResponse<ICentroCostos>> {
    const url = `${this.environment.faktumUrl}/CentroCosto/ConsultarCentroCostoId?idCentroCosto=${centroCostosID}`;
    return this.httpClient.get<IResponse<ICentroCostos>>(
      url
    )
  }

  crearCentroCostos(data: ICentroCostos): Observable<any> {
    const url = `${this.environment.faktumUrl}/CentroCosto/CrearCentroCosto`;

    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarCentroCostos(data: ICentroCostos): Observable<any> {
    const url = `${this.environment.faktumUrl}/CentroCosto/ActualizarCentroCosto`;

    return this.httpClient.post(
      url,
      data
    )
  }

  eliminarCentroCostos(centroCostoId: number): Observable<any> {
    const url = `${this.environment.faktumUrl}/CentroCosto/EliminarCentroCosto`;

    const data = {
      id: centroCostoId
    }

    return this.httpClient.post(
      url,
      data
    )
  }
}
