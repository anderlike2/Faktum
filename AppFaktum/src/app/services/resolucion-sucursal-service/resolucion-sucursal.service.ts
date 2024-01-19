import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { IResolucionSucursal } from 'src/app/models/resolucion-sucursal.model';

@Injectable({
  providedIn: 'root'
})
export class ResolucionSucursalService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  crearResolucionSucursal(data: IResolucionSucursal): Observable<any> {
    const url = `${this.environment.faktumUrl}/ResolucionSucursal/CrearResolucionSucursal`;
    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarResolucionSucursal(data: IResolucionSucursal): Observable<any> {
    const url = `${this.environment.faktumUrl}/ResolucionSucursal/ActualizarResolucionSucursal`;
    return this.httpClient.post(
      url,
      data
    )
  }

  obtenerResolucionSucursalPorId(resolucionSucursalId: number): Observable<IResponse<IResolucionSucursal>> {
    const url = `${this.environment.faktumUrl}/ResolucionSucursal/ConsultarResolucionSucursalId?idResolucionSucursal=${resolucionSucursalId}`;
    return this.httpClient.get<IResponse<IResolucionSucursal>>(
      url
    )
  }

}
