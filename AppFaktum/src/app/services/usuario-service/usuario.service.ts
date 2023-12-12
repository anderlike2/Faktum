import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { IEnvironment } from 'src/app/models/environment.model';
import { ICrearUsuario } from 'src/app/models/crear-usuario.model';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }
  
  crearUsuario(data: ICrearUsuario) {
    const url = `${this.environment.faktumUrl}/Usuario/CrearUsuario`;

    return this.httpClient.post(
      url,
      data
    );
  }
}
