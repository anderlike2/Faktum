import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IFormatoImpresion } from 'src/app/models/formato-impresion.model';
import { IResponse } from 'src/app/models/general.model';

@Injectable({
  providedIn: 'root'
})
export class FormatoImpresionService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerFormatosImpresionPorEmpresaId(empresaID: number): Observable<IFormatoImpresion[]> {
    const url = `${this.environment.faktumUrl}/FormatoImpresion/ConsultarFormatosImpresionEmpresa?idEmpresa=${empresaID}`;
    return this.httpClient.get<IResponse<IFormatoImpresion[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IFormatoImpresion[]
      )
    );
  }

  obtenerFormatoImpresionPorId(centroCostosID: number): Observable<IResponse<IFormatoImpresion>> {
    const url = `${this.environment.faktumUrl}/FormatoImpresion/ConsultarFormatoImpresionId?idFormatoImpresion=${centroCostosID}`;
    return this.httpClient.get<IResponse<IFormatoImpresion>>(
      url
    )
  }

  crearFormatoImpresion(data: IFormatoImpresion): Observable<any> {
    const url = `${this.environment.faktumUrl}/FormatoImpresion/CrearFormatoImpresion`;

    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarFormatoImpresion(data: IFormatoImpresion): Observable<any> {
    const url = `${this.environment.faktumUrl}/FormatoImpresion/ActualizarFormatoImpresion`;

    return this.httpClient.post(
      url,
      data
    )
  }
}
