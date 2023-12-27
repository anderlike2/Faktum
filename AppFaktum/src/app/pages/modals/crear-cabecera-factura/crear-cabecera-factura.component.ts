import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { DocumentoEnum } from 'src/app/models/facturacion.model';

@Component({
  selector: 'app-crear-cabecera-factura',
  templateUrl: './crear-cabecera-factura.component.html',
  styleUrls: ['./crear-cabecera-factura.component.scss']
})
export class CrearCabeceraFacturaComponent implements OnInit {

  centroCostosFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

  get listaDocumento() {
    return DocumentoEnum;
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      ccosNombre: [ { value: '', disabled: false }, [
            Validators.required
          ]
        ],
      ccosCodigo: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ]
    };

    this.centroCostosFormGroup = this.fb.group(formControls);
  }

  guardarEncabezado(): void {

  }

  cerrarModal() {
    this.modalRef.close();
  }

}
