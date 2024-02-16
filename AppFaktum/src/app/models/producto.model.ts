export interface IProducto {
  id?: number;
  estado: number;
  prodCodigo: string;
  prodListaPrecio: number;
  prodMarca: string;
  prodModelo: string;
  prodNombreFactura: string;
  prodNombreTecnico: string;
  prodUnidadHomologa: string;
  prodValor: number;
  prodCentroCostoId: number;
  prodCodReteFuenteId: number;
  prodCumId: number;
  prodCum: any;
  prodCupId: number;
  prodCup: any;
  prodEmpresaId: number;
  prodIumId: number;
  prodIum: any;
  prodTipoCupId: number;
  prodTipoImpuestoId: number;
  prodTipoRipsId: number;
  prodUnidadId: number;
  prodOtroProductoId: number;
  fechaCreacion: string;
  fechaModificacion: string | null;

  prodValorLista?: number;
  prodValorDescuento?: number;
  prodSeleccionado?: boolean | false;
}

export enum tipoConceptoEnum {
  CUPS = 'cups',
  MEDICAMENTOS = 'medicamentos',
  OTROS_PRODUCTOS = 'otros'
}
