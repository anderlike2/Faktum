import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { IEnvironment } from 'src/app/models/environment.model';
import { TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import swal from 'sweetalert2';
import * as CryptoJS from 'crypto-js';

@Injectable({
  providedIn: 'root'
})
export class GeneralService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  mostrarMensajeAlerta(mensaje: string, tipo: string, textoBoton: string){
    return swal.fire({
      text: mensaje,
      icon: tipo == TiposMensajeEnum.SUCCESS ? 'success' : (tipo == TiposMensajeEnum.WARNINNG ? 'warning' : (tipo == TiposMensajeEnum.ERROR ? 'error' : 'question')),
      confirmButtonText: textoBoton
    });
  }

  encrypt(texto: string) {
    const encrypt = CryptoJS.AES.encrypt(texto, this.environment.keyAes, { padding: CryptoJS.pad.Pkcs7 });
    return btoa(encrypt.toString());
  }

  decrypt(text: string): any {
    const decrypted = CryptoJS.AES.decrypt(atob(text), this.environment.keyAes);
    return decrypted.toString(CryptoJS.enc.Utf8);
  }
  
}
