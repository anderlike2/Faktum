import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { IListaPrecio } from 'src/app/models/lista-precio.model';

@Injectable({
  providedIn: 'root'
})
export class ListaPrecioService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerListaPreciosSucursalClienteId(sucursalClienteId: number): Observable<IListaPrecio[]> {
    const url = `${this.environment.faktumUrl}/ListaPrecio/ConsultarListaPreciosSucursalesCliente?idSucursalCliente=${sucursalClienteId}`;
    return this.httpClient.get<IResponse<IListaPrecio[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IListaPrecio[]
      )
    );
  }

  obtenerListaPrecioPorId(idListaPrecio: number): Observable<IResponse<IListaPrecio>> {
    const url = `${this.environment.faktumUrl}/ListaPrecio/ConsultarListaPrecioId?idFormatoImpresion=${idListaPrecio}`;
    return this.httpClient.get<IResponse<IListaPrecio>>(
      url
    )
  }

  crearListaPrecio(data: IListaPrecio): Observable<any> {
    const url = `${this.environment.faktumUrl}/ListaPrecio/CrearListaPrecio`;
    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarListaPrecio(data: IListaPrecio): Observable<any> {
    const url = `${this.environment.faktumUrl}/ListaPrecio/ActualizarListaPrecio`;
    return this.httpClient.post(
      url,
      data
    )
  }
}
