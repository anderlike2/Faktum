export interface IOtroProducto {
    id?: number;
    otprCodigo: string;
    otprNombre: string;
    otprEmpresaId: number;
    estado: number;
    fechaCreacion: string;
    fechaModificacion: string | null;
  }