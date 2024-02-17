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
        public const string msjPasswordNoCoincide = "La contraseña no coincide con su confirmación.";
        public const string msjFacturaNoInsertada = "No fue posible guardar la factura, por favor comuníquese con el Adminstrador del sistema.";
        public const string msjResolucionSucursalExiste = "La resolución ya se encuentra asociada a la sucursal seleccionada";
        public const string msjListaPrecioProductoExiste = "El producto seleccionado ya se encuentra agregado a la lista de precios.";
        public const string msjDependenciaProducto = "El registro no se puede eliminar porque se encuentra ligado a un Producto";
        public const string msjDependenciaSucursal = "El registro no se puede eliminar porque se encuentra ligado a una Sucursal";
        public const string msjDependenciaResolucionSucursal = "El registro no se puede eliminar porque se encuentra ligado a una Resolución Sucursal";
        public const string msjDependenciaListaPrecioProducto = "El registro no se puede eliminar porque se encuentra ligado a una Lista de Precio Producto";
        public const string msjDependenciaContratoSalud = "El registro no se puede eliminar porque se encuentra ligado a un Contrado de Salud";

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
        public const string depto = "depto";
        public const string rol = "rol";

        //ESTADOS
        public const string estadoActivo = "1";

        //FK Validaciones
        public const string fkProducto = "FK_Producto";
        public const string fkSucursal = "FK_Sucursal"; 
        public const string fkResolucionSucursal = "FK_ResolucionSucursal";
        public const string fkListaPrecioProducto = "FK_ListaPrecioProducto";
        public const string fkContratoSalud = "FK_ContratoSalud"; 
    }
}
