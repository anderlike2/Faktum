import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IUnidad } from 'src/app/models/unidad.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { UnidadService } from 'src/app/services/unidad-service/unidad.service';

@Component({
  selector: 'app-crear-unidad',
  templateUrl: './crear-unidad.component.html',
  styleUrls: ['./crear-unidad.component.scss']
})
export class CrearUnidadComponent implements OnInit {

  @Input() empresaID: number;

  unidadFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private unidadService: UnidadService,
    private generalService: GeneralService,
    private modalRef: NgbActiveModal) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
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

  guardarUnidad(): void {
    if (this.unidadFormGroup.invalid) {
      this.unidadFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IUnidad = this.unidadFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.unidEmpresaId = this.empresaID;

    this.unidadService.crearUnidad(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.cerrarModal(true);
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cerrarModal(info?: any) {
    this.modalRef.close(info);
  }
}
