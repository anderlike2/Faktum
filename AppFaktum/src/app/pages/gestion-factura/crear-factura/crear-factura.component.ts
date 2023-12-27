import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { DocumentoEnum } from 'src/app/models/facturacion.model';
import { CrearCabeceraFacturaComponent } from '../../modals/crear-cabecera-factura/crear-cabecera-factura.component';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-crear-factura',
  templateUrl: './crear-factura.component.html',
  styleUrls: ['./crear-factura.component.scss']
})
export class CrearFacturaComponent implements OnInit {

  facturaCollapsed: boolean = false;
  detalleFacturaCollapsed: boolean = false;

  detalleFacturaObs: Observable<any[]>;

  colsDetalleFactura: any[] = [
    { field: '', header: 'Código producto' },
    { field: '', header: 'Nombre producto' },
    { field: '', header: 'Cantidad' },
    { field: '', header: 'Marca' },
    { field: '', header: 'Modelo' },
    { field: '', header: 'Orden compra' },
    { field: '', header: 'Orden recepción' },
    { field: '', header: 'Tipo impuesto' },
    { field: '', header: 'Tipo retención' },
    { field: '', header: 'Porcentaje impuesto' },
    { field: '', header: 'Valor impuesto producto' },
    { field: '', header: 'Porcentaje retención' },
    { field: '', header: 'Valor rentención producto' },
    { field: '', header: 'Porcentaje descuento' },
    { field: '', header: 'Valor descuento' },
    { field: '', header: 'Valor total producto' },
    // { field: '', header: 'Valor total producto impuestos menos retención' }
  ];

  constructor(
    private modalService: NgbModal,
  ) { }

  ngOnInit(): void {
    // this.iniciarEncabezado();
  }

  get listaDocumento() {
    return DocumentoEnum;
  }

  iniciarEncabezado(): void {
    const modalEncabezado = this.modalService.open(
        CrearCabeceraFacturaComponent, {
          backdrop: 'static',
          keyboard: false,
          centered: true,
          size: 'xl'
      }
    );
  }

}
