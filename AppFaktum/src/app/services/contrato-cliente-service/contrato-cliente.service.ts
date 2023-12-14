import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEnvironment } from 'src/app/models/environment.model';
import { IResponse } from 'src/app/models/general.model';

@Injectable({
  providedIn: 'root'
})
export class ContratoClienteService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerContratoCliente(contratoClienteID: number): Observable<IResponse<IContratoCliente>> {
    const url = `${this.environment.faktumUrl}/ContratoSalud/ConsultarContratoId?idContrato=${contratoClienteID}`;
    return this.httpClient.get<IResponse<IContratoCliente>>(
      url
    )
  }

  crearContratoCliente(data: IContratoCliente): Observable<any> {
    const url = `${this.environment.faktumUrl}/ContratoSalud/CrearContratoSalud`;

    return this.httpClient.post(
      url,
      data
    )
  }

  actualizarContratoCliente(data: IContratoCliente): Observable<any> {
    const url = `${this.environment.faktumUrl}/ContratoSalud/ActualizarContratoSalud`;

    return this.httpClient.post(
      url,
      data
    )
  }
}
