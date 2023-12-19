import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IEnvironment } from 'src/app/models/environment.model';
import { IListCombo } from 'src/app/models/general.model';
import { TipoListEnum } from 'src/app/models/enums-aplicacion.model';
import { IEmpresa } from 'src/app/models/empresa.model';

@Injectable({
  providedIn: 'root'
})
export class CargueCombosService {

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

  obtenerEmpresas(): Observable<IEmpresa[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Empresa/ConsultarEmpresas`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          emprFactContador: item.emprFactContador,
          emprCelular: item.emprCelular,
          emprCiudad: item.emprCiudad,
          emprCiuu: item.emprCiuu,
          emprContacto: item.emprContacto,
          emprDepto: item.emprDepto,
          emprDiasPago: item.emprDiasPago,
          emprDireccion: item.emprDireccion,
          emprDv: item.emprDv,
          emprFormatoImpr: item.emprFormatoImpr,
          emprIdRepLegal: item.emprIdRepLegal,
          emprLeyEnFactura: item.emprLeyEnFactura,
          emprLeyEnNotaCredito: item.emprLeyEnNotaCredito,
          emprLeyEnNotaDebito: item.emprLeyEnNotaDebito,
          emprLocalidad: item.emprLocalidad,
          emprMail: item.emprMail,
          emprRecepcion: item.emprRecepcion,
          emprNit: item.emprNit,
          emprNombre: item.emprNombre,
          emprObservaciones: item.emprObservaciones,
          emprPagWeb: item.emprPagWeb,
          emprPorcReteIca: item.emprPorcReteIca,
          emprRepLegal: item.emprRepLegal,
          emprTelefono: item.emprTelefono,
          emprHabilitacion: item.emprHabilitacion,
          emprTipoClienteId: item.emprTipoClienteId,
          emprTipoIdId: item.emprTipoIdId,
          emprRespTributId: item.emprRespTributId,
          emprRegimenId: item.emprRegimenId,
          emprRespFiscalId: item.emprRespFiscalId,
          emprClasJuridicaId: item.emprClasJuridicaId,
          id: item.id,
          estado: item.estado,
          fechaCreacion: item.fechaCreacion,
          fechaModificacion: item.fechaModificacion
        })) as IEmpresa[])
    );
  }

  obtenerListaClasesJuridicas(): Observable<IListCombo[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Maestras/ConsultarTablaClasJuridica`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.juriNombre,
          codigo: item.juriCodigo
        })) as IListCombo[])
    );
  }

  obtenerListaCentrosCostoEmpresa(empresaID: number): Observable<any> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/CentroCosto/ConsultarCentrosCostoEmpresa?idEmpresa=${empresaID}`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.ccosNombre,
          codigo: item.ccosCodigo
        })) as IListCombo[])
    );
  }

  obtenerListaCiudadesDepto(idDepto: number): Observable<IListCombo[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Ciudad/ConsultarCiudadesDepto?idDepto=${idDepto}`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.ciudNombre,
          codigo: item.ciudCodigo
        })) as IListCombo[])
    );
  }

  obtenerListaFormatosImpresionEmpresa(empresaID: number): Observable<any> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/FormatoImpresion/ConsultarFormatosImpresionEmpresa?idEmpresa=${empresaID}`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.formNombre,
          codigo: item.formCodigo
        })) as IListCombo[])
    );
  }

  obtenerListaReteFuente(): Observable<IListCombo[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Maestras/ConsultarTablaRetefuente`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.reteNombre,
          codigo: item.Rete_1
        })) as IListCombo[])
    );
  }

  obtenerListaTablaCum(): Observable<IListCombo[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Maestras/ConsultarTablaCum`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.cumsNombre,
          codigo: item.cumsCodigo
        })) as IListCombo[])
    );
  }

  obtenerListaTablaImpuestos(): Observable<IListCombo[]> {
    return this.httpClient.get<any>(
      `${this.environment.faktumUrl}/Maestras/ConsultarTablaImpuesto`
    )
    .pipe(
      map((response) =>
        response.data?.map((item) => ({
          valor: item.id,
          nombre: item.impuNombre,
          codigo: item.impuCodigo
        })) as IListCombo[])
    );
  }

}
