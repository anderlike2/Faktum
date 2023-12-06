export interface ICliente{
    clieApellidos: string;
    clieCelular: string;
    clieCiuu: string;
    clieCobertura: string;
    clieContacto: string;
    clieCorreo: string;
    clieCorreoFact: string;
    clieDescGlobal: number;
    clieDiasPago: number;
    clieDireccion: string;
    clieDv: number;
    clieEstadoOperacion: number;
    clieIdReprLegal: string;
    clieJuridica: string;
    clieLocalidad: string;
    clieNit: string;
    cliePaginaWeb: string;
    cliePrimerNom: string;
    clieRazonSocial: string;
    clieReprLegal: string;
    clieSegundoNom: string;
    clieTelFijo: string;
    clieCiudadId: number;
    clieDeptoId: number;
    cliePaisId: number;
    clieEmpresaId: number;
    clieRegimenId: number;
    clieRespFiscalId: number;
    clieRespTributariaId: number;
    clieTipoClienteId: number;
    clieTipoIdId: number;
    clieClasJuridicaId: number;
    id: number;
    estado: number;
    fechaCreacion: string;
    fechaModificacion: string | null;
}