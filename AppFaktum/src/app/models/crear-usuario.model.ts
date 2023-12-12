import { IUsuarioRol } from './usuario.model';
import { IEmpresa } from './empresa.model';

export interface ICrearUsuario {
    id: number;
    usuaUsuario: string;
    usuaPassword: string;
    usuaPasswordConfirm: string;
    usuaIntentos: number;
    usuaEmpresas: IEmpresa[];
    usuaRoles: IUsuarioRol[];
    usuaEmpresaId: number;
    usuaRolId: number;
    estado: number;
    fechaCreacion: string;
    fechaModificacion: string;
}