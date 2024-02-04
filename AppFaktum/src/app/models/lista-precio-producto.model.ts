import { IListaPrecio } from "./lista-precio.model";
import { IProducto } from "./producto.model";

export interface IListaPrecioProducto{
    id: number;
    lproValor: number;
    lproDescuento: number;
    lproListaPrecioId: number;
    lproListaPrecioAnteriorId?: number;
    lproProductoId: number;
    lproProducto: IProducto,
    lproListaPrecio: IListaPrecio,
    estado: number;
    fechaCreacion: string;
    fechaModificacion: string;
}