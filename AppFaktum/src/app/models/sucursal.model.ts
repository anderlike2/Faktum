export interface ISucursal {
  id?: number;
  estado?: number;
  fechaCreacion?: string;
  fechaModificacion?: string;
  sucuDepto: string;
  sucuCelular: string;
  sucuCiudad: string,
  sucuCodigo: string;
  sucuContacto: string;
  sucuDireccion: string;
  sucuEstadoOperacio: number;
  sucuHabilitacion: string;
  sucuLeyendaFactura: string;
  sucuLeyendaNotaCredito: string;
  sucuLeyendaNotaDebito: string;
  sucuListPrecio: string;
  sucuMail: string;
  sucuNombre: string;
  sucuObservaciones: string;
  sucuPrincipal: number;
  sucuReteIca: number;
  sucuTelefono: string;
  sucuCentroCostosId: number;
  sucuEmpresaId: number;
  sucuFormatoImpresionId: number;
}
