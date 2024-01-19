import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { ISucursal } from 'src/app/models/sucursal.model';

@Injectable({
  providedIn: 'root'
})
export class SucursalService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerSucursalPorId(sucursalId: number): Observable<IResponse<ISucursal>> {
    const url = `${this.environment.faktumUrl}/Sucursal/ConsultarSucursalId?idSucursal=${sucursalId}`;
    return this.httpClient.get<IResponse<ISucursal>>(
      url
    )
  }
}
