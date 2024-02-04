export interface IListaPrecio {
    id?: number;
    liprDescripcion: string;    
    liprEstadoOperacion: number;
    liprNombre: string;
    liprEmpresaId: number;
    estado: number;
    fechaCreacion: string;
    fechaModificacion: string | null;
  }