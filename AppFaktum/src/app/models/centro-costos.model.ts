export interface ICentroCostos {
  id?: number;
  ccosCodigo: string;
  ccosNombre: string;
  ccosEmpresaId: number;
  estado: number;
  fechaCreacion: string;
  fechaModificacion: string | null;
}
