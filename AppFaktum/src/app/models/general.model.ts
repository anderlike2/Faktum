export interface IListCombo {
  valor: number;
  nombre: string;
  codigo?: string;
}

export interface IResponse<T>{
  success: boolean;
  message: string;
  data: T
}
