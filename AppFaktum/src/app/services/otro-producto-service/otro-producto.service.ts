import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { IOtroProducto } from 'src/app/models/otro-producto.model';

@Injectable({
  providedIn: 'root'
})
export class OtroProductoService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerOtrosProductosPorEmpresaId(empresaId: number): Observable<IOtroProducto[]> {
    const url = `${this.environment.faktumUrl}/OtroProducto/ConsultarOtrosProductosEmpresa?idEmpresa=${empresaId}`;
    return this.httpClient.get<IResponse<IOtroProducto[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IOtroProducto[]
      )
    );
  }

  obtenerOtroProductoPorId(otroProductoId: number): Observable<IResponse<IOtroProducto>> {
    const url = `${this.environment.faktumUrl}/OtroProducto/ConsultarOtroProductoId?idOtroProducto=${otroProductoId}`;
    return this.httpClient.get<IResponse<IOtroProducto>>(
      url
    )
  }

  crearOtroProducto(data: IOtroProducto): Observable<any> {
    const url = `${this.environment.faktumUrl}/OtroProducto/CrearOtroProducto`;
    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarOtroProucto(data: IOtroProducto): Observable<any> {
    const url = `${this.environment.faktumUrl}/OtroProducto/ActualizarOtroProducto`;
    return this.httpClient.post(
      url,
      data
    )
  }
}
