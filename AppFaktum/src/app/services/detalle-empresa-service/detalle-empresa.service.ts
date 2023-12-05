import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IListCombo } from 'src/app/models/general.model';
import { TipoListEnum } from 'src/app/models/detalle-empresa.model';

@Injectable({
  providedIn: 'root'
})
export class DetalleEmpresaService {

  constructor(
    @Inject('environment') private environment: IEnvironment,
    private httpClient: HttpClient
  ) { }



  obtenerListaTablaMaestro(claseTipo: string): Observable<IListCombo[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Maestras/ConsultarTablaMaestra?tipoClase=${claseTipo}`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.nombre,
          codigo: item.codigo
        })) as IListCombo[])
    );
  }

  obtenerListaRegimen(): Observable<IListCombo[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Maestras/ConsultarTablaRegimen`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.regiNombre,
          codigo: item.regiCodigo
        })) as IListCombo[])
    );
  }
}
