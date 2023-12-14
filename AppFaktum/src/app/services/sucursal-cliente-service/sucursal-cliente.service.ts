import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { ISucursalCliente } from 'src/app/models/sucursal-cliente.model';

@Injectable({
  providedIn: 'root'
})
export class SucursalClienteService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerInformacionSucursalClienteId(idSucursalCliente: number): Observable<ISucursalCliente> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/SucursalCliente/ConsultarSucursalClienteId?idSucursalCliente=${idSucursalCliente}`
    )
    .pipe(
      map((response) =>
        response.data as ISucursalCliente
       )
    );
  }

  actualizarCliente(data: ISucursalCliente): Observable<any> {
    const url = `${this.environment.faktumUrl}/SucursalCliente/ActualizarSucursalCliente`;
    return this.httpClient.post(
      url,
      data
    );
  }
}
