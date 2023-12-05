import { IUsuario, IUsuarioRol } from './usuario.model';
import { IEmpresa } from './empresa.model';

export interface ILogin {
  usuario: string;
  clave: string;
}

export interface ILoginResponse extends IUsuario {
  usuEmpresas: IEmpresa[];
  usuRoles: IUsuarioRol[];
}
