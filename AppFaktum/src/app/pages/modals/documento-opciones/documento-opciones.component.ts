import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { TipoListEnum } from 'src/app/models/enums-aplicacion.model';
import { DocumentoEnum } from 'src/app/models/facturacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';

@Component({
  selector: 'app-documento-opciones',
  templateUrl: './documento-opciones.component.html',
  styleUrls: ['./documento-opciones.component.scss']
})
export class DocumentoOpcionesComponent implements OnInit {

  listaClaseFactura: IListCombo[] = [];

  opciones = [];

  constructor(
    private modalRef: NgbActiveModal,
    private cargueCombosService: CargueCombosService
  ) { }

  ngOnInit(): void {
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.CLASE_FACTURA).subscribe({
      next: (response) => {
        this.listaClaseFactura = response;
        response.map(item => {
          const opt = {
            name: item.nombre,
            action: () => {
              this.accionOpcion(item.valor, item.codigo, item.nombre)
            }
          }

          this.opciones.push(opt);
        });
      }
    });
  }

  accionOpcion(id: number, codigo: string, nombre: string): void {
    this.cerrarModal({
      id: id,
      codigo: codigo,
      nombre: nombre
    });
  }

  cerrarModal(info?: string | any | undefined) {
    this.modalRef.close(info);
  }

}
