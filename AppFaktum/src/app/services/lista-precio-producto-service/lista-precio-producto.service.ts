import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { IListaPrecioProducto } from 'src/app/models/lista-precio-producto.model';

@Injectable({
  providedIn: 'root'
})
export class ListaPrecioProductoService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  crearListaPrecio(data: IListaPrecioProducto[]): Observable<any> {
    const url = `${this.environment.faktumUrl}/ListaPrecioProducto/CrearListaPrecioProducto`;
    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarListaPrecio(data: IListaPrecioProducto): Observable<any> {
    const url = `${this.environment.faktumUrl}/ListaPrecioProducto/ActualizarListaPrecioProducto`;
    return this.httpClient.post(
      url,
      data
    )
  }

  obtenerProductosPorListaPrecio(idListaPrecio: number): Observable<IListaPrecioProducto[]> {
    const url = `${this.environment.faktumUrl}/ListaPrecioProducto/ConsultarProductosListaPrecioId?idListaPrecio=${idListaPrecio}`;
    return this.httpClient.get<IResponse<IListaPrecioProducto[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IListaPrecioProducto[]
      )
    );
  }

  eliminarListaPrecio(data: IListaPrecioProducto): Observable<any> {
    const url = `${this.environment.faktumUrl}/ListaPrecioProducto/EliminarListaPrecioProducto`;
    return this.httpClient.post(
      url,
      data
    )
  }

  obtenerListaPrecioProductoPorId(idListaPrecioProducto: number): Observable<IResponse<IListaPrecioProducto>> {
    const url = `${this.environment.faktumUrl}/ListaPrecioProducto/ConsultarListaPrecioProductoPorId?idListaPrecioProducto=${idListaPrecioProducto}`;
    return this.httpClient.get<IResponse<IListaPrecioProducto>>(
      url
    )
  }
}
