export interface IListaPrecio {
    id?: number;
    liprDescripcion: string;
    liprDescuento: number;
    liprEstadoOperacion: number;
    liprNombre: string;
    liprValor: number;
    liprProductoId: number;
    estado: number;
    fechaCreacion: string;
    fechaModificacion: string | null;
  }