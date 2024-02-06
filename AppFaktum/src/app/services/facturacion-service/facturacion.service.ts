import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEnvironment } from 'src/app/models/environment.model';
import { IDetalleFactura, IFactura } from 'src/app/models/facturacion.model';

@Injectable({
  providedIn: 'root'
})
export class FacturacionService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }

  crearFactura(factura: IFactura): Observable<any> {
    return this.httpClient.post(
      `${this.environment.faktumUrl}/Factura/CrearFactura`,
      factura
    );
  }

  crearDetalleFactura(detalleFactura: IDetalleFactura[]): Observable<any> {
    return this.httpClient.post(
      `${this.environment.faktumUrl}/Factura/CrearDetalleFactura`,
      detalleFactura
    );
  }

  actualizarFactura(factura: IFactura): Observable<any> {
    return this.httpClient.post(
      `${this.environment.faktumUrl}/Factura/ActualizarFactura`,
      factura
    );
  }

}
