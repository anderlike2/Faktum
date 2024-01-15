import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { FormatoImpresionService } from 'src/app/services/formato-impresion-service/formato-impresion.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { IFormatoImpresion } from 'src/app/models/formato-impresion.model';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';

@Component({
  selector: 'app-crear-formato-impresion',
  templateUrl: './crear-formato-impresion.component.html',
  styleUrls: ['./crear-formato-impresion.component.scss']
})
export class CrearFormatoImpresionComponent implements OnInit {

  @Input() empresaID: number;

  formatoImpresionFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private formatoImpresionService: FormatoImpresionService,
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
      formNombre: [ { value: '', disabled: false }, [ Validators.required ] ],
      formCodigo: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.formatoImpresionFormGroup = this.fb.group(formControls);
  }

  get formNombreErrorMensaje(): string {
    const form: AbstractControl = this.formatoImpresionFormGroup.get('formNombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get formCodigoErrorMensaje(): string {
    const form: AbstractControl = this.formatoImpresionFormGroup.get('formCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  guardarFormatoImpresion(): void {
    if (this.formatoImpresionFormGroup.invalid) {
      this.formatoImpresionFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IFormatoImpresion = this.formatoImpresionFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.formEmpresaId = this.empresaID;

    this.formatoImpresionService.crearFormatoImpresion(dataBody).subscribe({
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
