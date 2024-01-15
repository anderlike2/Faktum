import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ICentroCostos } from 'src/app/models/centro-costos.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { CentroCostosService } from 'src/app/services/centro-costos-service/centro-costos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Component({
  selector: 'app-editar-centro-costos',
  templateUrl: './editar-centro-costos.component.html',
  styleUrls: ['./editar-centro-costos.component.scss']
})
export class EditarCentroCostosComponent implements OnInit {

  centroCostosCollapsed: boolean = false;
  edicionCentroCostos: boolean = false;

  centroCostosData: ICentroCostos;

  centroCostosFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(
    private centroCostosService: CentroCostosService,
    private cargueCombosService: CargueCombosService,
    private sharedService: SharedService,
    private generalService: GeneralService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {

    this.sharedService.editarGeneralDataListener$.subscribe(this.obtenerCentroCostos.bind(this));

    this.initForm();
    this.cargarListaCombox();
  }

  cargarListaCombox(): void {

  }

  obtenerCentroCostos(data: ICentroCostos): void {
    this.centroCostosService.obtenerCentroCostosPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.centroCostosData = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  cargarDataForm(data: ICentroCostos): void {
    this.centroCostosFormGroup.disable();
    this.edicionCentroCostos = false;
    this.centroCostosFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.centroCostosFormGroup.enable();
    this.edicionCentroCostos = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.centroCostosData);
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

  get ccosNombreErrorMensaje(): string {
    const form: AbstractControl = this.centroCostosFormGroup.get('ccosNombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get ccosCodigoErrorMensaje(): string {
    const form: AbstractControl = this.centroCostosFormGroup.get('ccosCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }


  guardarCentroCostos(): void {
    if (this.centroCostosFormGroup.invalid) {
      this.centroCostosFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ICentroCostos = this.centroCostosFormGroup.getRawValue();

    dataBody.id = this.centroCostosData.id;
    dataBody.estado = this.centroCostosData.estado;

    // toca hablar de estos dos
    dataBody.ccosEmpresaId = this.centroCostosData.ccosEmpresaId;
    dataBody.fechaCreacion = this.centroCostosData.fechaCreacion;
    dataBody.fechaModificacion = this.centroCostosData.fechaModificacion;

    this.centroCostosService.actualizarCentroCostos(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.centroCostosFormGroup.disable();
          this.edicionCentroCostos = false;
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
