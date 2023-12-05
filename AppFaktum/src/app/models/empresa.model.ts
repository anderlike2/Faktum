export interface IEmpresa {
  id: number;
  emprFactContador: number;
  emprCelular: string;
  emprCiudad: string;
  emprCiuu: string;
  emprContacto: string;
  emprDepto: string;
  emprDiasPago: number;
  emprDireccion: string;
  emprDv: string;
  emprFormatoImpr: string;
  emprIdRepLegal: string;
  emprLeyEnFactura: string;
  emprLeyEnNotaCredito: string;
  emprLeyEnNotaDebito: string;
  emprLocalidad: string;
  emprMail: string;
  emprRecepcion: string;
  emprNit: string;
  emprNombre: string;
  emprObservaciones: string;
  emprPagWeb: string;
  emprPorcReteIca: number;
  emprRepLegal: string;
  emprTelefono: string;
  emprHabilitacion: string;
  emprTipoClienteId: number;
  emprTipoIdId: number;
  emprRespTributId: number;
  emprRegimenId: number;
  emprRespFiscalId: number;
  emprClasJuridicaId: number;
  estado: number;
  fechaCreacion: string;
  fechaModificacion: string | null;
}
