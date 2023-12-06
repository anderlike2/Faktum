import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEnvironment } from 'src/app/models/environment.model';
import {ICliente } from 'src/app/models/cliente.model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }
  
  obtenerInformacionClienteId(idCliente: number): Observable<ICliente> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Cliente/ConsultarClienteId?idCliente=${idCliente}`
    )
    .pipe(
      map((response) =>
        response.data as ICliente
       )
    );
  }

}
