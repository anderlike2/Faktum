import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
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

}
