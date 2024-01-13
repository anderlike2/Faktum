import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEnvironment } from 'src/app/models/environment.model';
import {ICliente } from 'src/app/models/cliente.model';
import {IContratoCliente } from 'src/app/models/contrato-cliente.model';
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

  obtenerInformacionContratosClienteId(idCliente: number): Observable<IContratoCliente[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/ContratoSalud/ConsultarContratosSaludCliente?idCliente=${idCliente}`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          cosaContrato: item.cosaContrato,
          cosaNitCliente: item.cosaNitCliente,
          cosaPoliza: item.cosaPoliza,
          cosaClieId: item.cosaClieId,
          cosaCobeId: item.cosaCobeId,
          cosaEmpresaId: item.cosaEmpresaId,
          cosaMopaId: item.cosaMopaId,
          id: item.id,
          estado: item.estado,
          fechaCreacion: item.fechaCreacion,
          fechaModificacion: item.fechaModificacion
        })) as IContratoCliente[])
    );
  }

  actualizarCliente(data: ICliente): Observable<any> {
    const url = `${this.environment.faktumUrl}/Cliente/ActualizarCliente`;
    return this.httpClient.post(
      url,
      data
    );
  }

  crearCliente(data: ICliente): Observable<any> {
    const url = `${this.environment.faktumUrl}/Cliente/CrearCliente`;
    return this.httpClient.post(
      url,
      data
    );
  }

}
