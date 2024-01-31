export class IProductoLista {
  id?: number;
  prodCodigo: string;
  prodMarca: string;
  prodModelo: string;
  prodValor: number;
  prodValorLista: number;
  prodValorDescuento: number;
  prodSeleccionado: boolean | false;
}