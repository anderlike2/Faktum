import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IUnidad } from 'src/app/models/unidad.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { UnidadService } from 'src/app/services/unidad-service/unidad.service';

@Component({
  selector: 'app-editar-unidad',
  templateUrl: './editar-unidad.component.html',
  styleUrls: ['./editar-unidad.component.scss']
})
export class EditarUnidadComponent implements OnInit {

  unidadCollapsed: boolean = false;
  edicionUnidad: boolean = false;

  unidadData: IUnidad;

  unidadFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private unidadService: UnidadService,
    private sharedService: SharedService,
    private generalService: GeneralService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.editarGeneralDataListener$.subscribe(this.obtenerUnidad.bind(this));
    this.initForm();
  }

  obtenerUnidad(data: IUnidad): void {
    this.unidadService.obtenerUnidadPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.unidadData = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      unidNombre: [ { value: '', disabled: false }, [ Validators.required ] ],
      unidCodigoDian: [ { value: '', disabled: false }, [ Validators.required ] ],
      unidCodigo: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.unidadFormGroup = this.fb.group(formControls);
  }

  get unidNombreErrorMensaje(): string {
    const form: AbstractControl = this.unidadFormGroup.get('unidNombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get unidCodigoDianErrorMensaje(): string {
    const form: AbstractControl = this.unidadFormGroup.get('unidCodigoDian') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get unidCodigoErrorMensaje(): string {
    const form: AbstractControl = this.unidadFormGroup.get('unidCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  cargarDataForm(data: IUnidad): void {
    this.unidadFormGroup.disable();
    this.edicionUnidad = false;
    this.unidadFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.unidadFormGroup.enable();
    this.edicionUnidad = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.unidadData);
  }

  guardarUnidad(): void {
    if (this.unidadFormGroup.invalid) {
      this.unidadFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IUnidad = this.unidadFormGroup.getRawValue();

    dataBody.id = this.unidadData.id;
    dataBody.estado = this.unidadData.estado;
    dataBody.unidEmpresaId = this.unidadData.unidEmpresaId;
    dataBody.fechaCreacion = this.unidadData.fechaCreacion;
    dataBody.fechaModificacion = this.unidadData.fechaModificacion;

    this.unidadService.actualizarUnidad(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.unidadFormGroup.disable();
          this.edicionUnidad = false;
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
