import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { DocumentoEnum } from 'src/app/models/facturacion.model';

@Component({
  selector: 'app-documento-opciones',
  templateUrl: './documento-opciones.component.html',
  styleUrls: ['./documento-opciones.component.scss']
})
export class DocumentoOpcionesComponent implements OnInit {

  opciones = [
    {
      name: 'Factura comercial',
      action: () => {
        const code = DocumentoEnum.COMERCIAL;
        this.accionOpcion(code);
      }
    },
    {
      name: 'Factura salud',
      action: () => {
        const code = DocumentoEnum.SECTOR_SALUD;
        this.accionOpcion(code);
      }
    }
  ];

  constructor(
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

  accionOpcion(codigo: string): void {
    this.cerrarModal(codigo);
  }

  cerrarModal(info?: string | undefined) {
    this.modalRef.close(info);
  }

}
