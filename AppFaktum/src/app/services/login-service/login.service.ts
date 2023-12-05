import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEnvironment } from 'src/app/models/environment.model';
import { ILogin } from '../../models/login.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  login({usuario, clave}: ILogin): Observable<any> {

    const url = `${this.environment.faktumUrl}/Usuario/IniciarSesion`;
    const body = {
      usuaUsuario: usuario,
      usuaPassword: clave
    };

    return this.httpClient.post(
      url,
      body
    );
  }
}
