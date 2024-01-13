import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IOtroProducto } from 'src/app/models/otro-producto.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { OtroProductoService } from 'src/app/services/otro-producto-service/otro-producto.service';

@Component({
  selector: 'app-crear-otro-producto',
  templateUrl: './crear-otro-producto.component.html',
  styleUrls: ['./crear-otro-producto.component.scss']
})
export class CrearOtroProductoComponent implements OnInit {

  @Input() empresaID: number;

  otroProductoFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private otroProductoService: OtroProductoService, private generalService: GeneralService,
    private modalRef: NgbActiveModal) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      otprCodigo: [ { value: '', disabled: false }, [ Validators.required ] ],
      otprNombre: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.otroProductoFormGroup = this.fb.group(formControls);
  }

  get otprCodigoErrorMensaje(): string {
    const form: AbstractControl = this.otroProductoFormGroup.get('otprCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get otprNombreErrorMensaje(): string {
    const form: AbstractControl = this.otroProductoFormGroup.get('otprNombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  guardarOtroProducto(): void {
    if (this.otroProductoFormGroup.invalid) {
      this.otroProductoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IOtroProducto = this.otroProductoFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.otprEmpresaId = this.empresaID;

    this.otroProductoService.crearOtroProducto(dataBody).subscribe({
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
