export interface IFactura {
  id: number;
  estado: number;
  fechaCreacion?: string;
  fechaModificacion?: string;
  factFechaTrm: string;
  factCompartidos: number;
  factContador: number;
  factContrato: string;
  factCopago: number;
  factCufe: string;
  factCuotaRecupera: number;
  factDescGlobal: number;
  factDespacho: string;
  factEstadoOperacion: number;
  factFecha: string;
  factFechaFinal: string;
  factFechaInicio: string;
  factFechaVence: string;
  factModalidadPago: string;
  factModeradora: number;
  factNumero: string;
  factObservaciones: string;
  factOperador: string;
  factOrden: string;
  factPoliza: string;
  factPorcIva: string;
  factRecepcion: string;
  factRemision: string;
  factSubtotal: number;
  factSucursal: string;
  factTotalIva: number;
  factTotalReteIca: string;
  factTrm: string;
  factValAnticipo: number;
  factValor: number;
  factValorDescuento: number;
  factValTotRetefuente: string;
  factVendedor: string;
  factClaseFacturaId: number;
  factCoberturaId: number;
  factCondicionVentaId: number;
  factEmpresaId: number;
  factEstadoDianId: number;
  factFormaPagoId: number;
  factFormatoImpresionId: number;
  factMonedaId: number;
  factSaludTipoId: number;
  factTipoDescuentoId: number;
  factTipoDocElectrId: number;
  factListaPreciosId: number;
  factNotaDebitoId: number;
  factNotaCreditoId: number;
  factClienteId: number;
}

export interface IDetalleFactura {
  id: number;
  estado: number;
  fechaCreacion: string;
  fechaModificacion: string;
  detaCantidad: number;
  detaCentroCostos: number;
  detaDescripcion: string;
  detaFactCodigo: string;
  detaFechaDespacho: string;
  detaIva: number;
  detaLinea: number;
  detaListaPrecio: string;
  detaOrdenCompra: string;
  detaPorDescuento: number;
  detaPorcIva: number;
  detaPorcCrf: number;
  detaProducto: number;
  detaRemision: string;
  detaValor: number;
  detaValorUnitario: number;
  detaValReteIca: number;
  detaValRf: number;
  detaEmpresaId: number;
  detaFacturaId: number;
  detaRetefuenteId: number;
  detaTipoImpuestoId: number;
  detaUnidadId: number;
  detaListaPreciosId: number;
}