export interface IResolucion {
    id?: number;
    resoAnio: string;
    resoConsActual: number;
    resoConsFinal: number;
    resoConsInicial: number;
    resoEstadoOperacion: number;
    resoFechaExpide: Date;
    resoPrefijo: string;
    resoVigencia: Date;
    resoCodigo: string;
    resoNumeracionActual: number;
    resoEmpresaId: number;
    resoTipoDocId: number;
    estado: number;
    fechaCreacion: string;
    fechaModificacion: string | null;
  }