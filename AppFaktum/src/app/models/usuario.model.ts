export interface IUsuario {
  id: number;
  usuaUsuario: string;
  estado: number;
  fechaCreacion: string;
  fechaModificacion: string | null;
}

export interface IUsuarioRol {
  id: number;
  rolCodigo: string;
  rolDescripcion: string;
  estado: number;
  fechaCreacion: string;
  fechaModificacion: string | null;
}
