import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-editar-sucursal-cliente',
  templateUrl: './editar-sucursal-cliente.component.html',
  styleUrls: ['./editar-sucursal-cliente.component.scss']
})
export class EditarSucursalClienteComponent implements OnInit {

  sucursalClienteCollapsed: boolean = true;
  preciosSucursalClienteCollapsed: boolean = true;

  constructor() { }

  ngOnInit(): void {
  }

}
