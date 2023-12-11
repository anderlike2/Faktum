import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IEnvironment } from 'src/app/models/environment.model';

@Injectable({
  providedIn: 'root'
})
export class EmpresaService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }


  crearEmpresa(data: IEmpresa) {
    const url = `${this.environment.faktumUrl}/Empresa/CrearEmpresa`;

    return this.httpClient.post(
      url,
      data
    );
  }

  consultarEmpresasUsusario(usuarioID: number): Observable<any> {
    const url = `${this.environment.faktumUrl}/Usuario/ConsultarEmpresasUsuario`;

    const body = {
      id: usuarioID
    };

    return this.httpClient.post<any>(
      url,
      body
    )
    .pipe(
      map((response) =>
        response.data as IEmpresa[]
      )
    );;
  }

}
