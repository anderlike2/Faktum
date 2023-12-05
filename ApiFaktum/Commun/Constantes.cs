namespace Commun
{
    public class Constantes
    {
        public const string IntentosInicioSesion = "3";

        //ROLES
        public const string rolAdministrador = "ROL_ADMINISTRADOR";
        public const string rolOperativo = "ROL_OPERATIVO";

        //MENSAJES
        public const string msjNoAutorizado = "No autorizado";
        public const string msjLoginErrado = "Usuario o Password Incorrectos. Su usuario será bloqueado en {a} intento(s).";
        public const string msjUsuarioNoExiste = "El usuario ingresado no existe en nuestro sistema.";
        public const string msjUsuarioBloqueado = "El usuario ha sido bloqueado o inactivado, por favor contactar al Administrador del sistema.";
        public const string msjUsuarioSinRoles = "El usuario no tiene roles asociados.";
        public const string msjUsuarioNoInsertado = "No fue posible guardar el usuario, por favor comuníquese con el Adminstrador del sistema.";
        public const string msjUsuarioSinEmpresas = "El usuario no tiene empresas asociadas.";
        public const string msjUsuarioYaCreado = "El usuario ya se encuentra creado en el sistema.";
        public const string msjLoginCorrecto = "Credenciales válidas.";
        public const string msjNoHayRegistros = "No se encuentran registros para los criterios de búsqueda ingresados.";
        public const string msjRegActualizado = "Registro actualizado con éxito.";
        public const string msjRegEliminado = "Registro eliminado con éxito.";
        public const string msjRegGuardado = "Registro almacenado con éxito.";
        public const string msjUsuarioEliminado = "Usuario eliminado con éxito.";
        public const string msjConsultaExitosa = "Consulta realizada con éxito.";
        public const string msjSucursalCentroCosto= "El centro de costo se encuentra asignado a una sucursal. No es posible eliminar.";

        //TIPOS DE CLASE MAESTRO
        public const string claseFactura = "claseFactura";
        public const string tipoCliente = "tipoCliente";
        public const string tipoCups = "tipoCups";
        public const string tipoDocElectr = "tipoDocElectr";
        public const string moneda = "moneda";
        public const string tipoId = "tipoId";
        public const string tipoDescuento = "tipoDescuento";
        public const string tipoArchivoRips = "tipoArchivoRips";
        public const string respTributaria = "respTributaria";
        public const string respFiscal = "respFiscal";
        public const string formaPago = "formaPago";
        public const string factSaludTipo = "factSaludTipo";
        public const string estadoDianFactura = "estadoDianFactura";
        public const string cups = "cups";
        public const string condicionVenta = "condicionVenta";
        public const string pais = "pais";
        public const string modalidadPago = "modalidadPago";
        public const string conceptoNotas = "conceptoNotas";
        public const string cobertura = "cobertura";

        //ESTADOS
        public const string estadoActivo = "1";
    }
}
