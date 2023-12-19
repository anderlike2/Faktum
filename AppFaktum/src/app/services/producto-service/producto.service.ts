import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';
import { IProducto } from 'src/app/models/producto.model';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerProductosPorEmpresaid(empresaId: number): Observable<IProducto[]> {
    const url = `${this.environment.faktumUrl}/Producto/ConsultarProductosEmpresa?idEmpresa=${empresaId}`;
    return this.httpClient.get<IResponse<IProducto[]>>(
      url
    ).pipe(
      map((response) =>
        response.data as IProducto[]
      )
    );
  }

  crearProducto(data: IProducto): Observable<any> {
    const url = `${this.environment.faktumUrl}/Producto/CrearProducto`;

    return this.httpClient.post(
      url,
      data
    );
  }

  actualizarProducto(data: IProducto): Observable<any> {
    const url = `${this.environment.faktumUrl}/Producto/ActualizarProducto`;

    return this.httpClient.post(
      url,
      data
    );
  }
}
