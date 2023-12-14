import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { CentroCostosService } from 'src/app/services/centro-costos-service/centro-costos.service';
import { ICentroCostos } from 'src/app/models/centro-costos.model';

@Component({
  selector: 'app-crear-centro-costos',
  templateUrl: './crear-centro-costos.component.html',
  styleUrls: ['./crear-centro-costos.component.scss']
})
export class CrearCentroCostosComponent implements OnInit {

  @Input() empresaID: number;

  centroCostosFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(
    private centroCostosService: CentroCostosService,
    private cargueCombosService: CargueCombosService,
    private generalService: GeneralService,
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarListaCombox();
  }

  cargarListaCombox(): void {

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


  guardarCentroCostos(): void {
    if (this.centroCostosFormGroup.invalid) {
      this.centroCostosFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ICentroCostos = this.centroCostosFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;

    dataBody.ccosEmpresaId = this.empresaID;

    this.centroCostosService.crearCentroCostos(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
           this.cerrarModal();
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cerrarModal() {
    this.modalRef.close();
  }

}
