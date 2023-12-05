import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { IEnvironment } from '../../models/environment.model';
import { IResAuthToken } from '../../models/auth.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  obtenerClave(): Observable<IResAuthToken> {

    const url = `${this.environment.faktumUrl}/AuthToken`;

    const body = {
      key: this.environment.key,
      apiKey: this.environment.apiKey
    }

    return this.httpClient.post<IResAuthToken>(
      url,
      body
    );
  }
}
