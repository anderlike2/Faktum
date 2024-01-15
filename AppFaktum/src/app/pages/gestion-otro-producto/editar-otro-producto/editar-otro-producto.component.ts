import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IOtroProducto } from 'src/app/models/otro-producto.model';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { OtroProductoService } from 'src/app/services/otro-producto-service/otro-producto.service';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-editar-otro-producto',
  templateUrl: './editar-otro-producto.component.html',
  styleUrls: ['./editar-otro-producto.component.scss']
})
export class EditarOtroProductoComponent implements OnInit {

  otroProductoCollapsed: boolean = false;
  edicionOtroProducto: boolean = false;

  otroProductoData: IOtroProducto;

  otroProductoFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private sharedService: SharedService, private otroProductoService: OtroProductoService,
    private generalService: GeneralService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.editarGeneralDataListener$.subscribe(this.obtenerOtroProducto.bind(this));
    this.initForm();
  }

  obtenerOtroProducto(data: IOtroProducto): void {
    this.otroProductoService.obtenerOtroProductoPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.otroProductoData = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
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

  cargarDataForm(data: IOtroProducto): void {
    this.otroProductoFormGroup.disable();
    this.edicionOtroProducto = false;
    this.otroProductoFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.otroProductoFormGroup.enable();
    this.edicionOtroProducto = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.otroProductoData);
  }

  guardarOtroProducto(): void {
    if (this.otroProductoFormGroup.invalid) {
      this.otroProductoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IOtroProducto = this.otroProductoFormGroup.getRawValue();

    dataBody.id = this.otroProductoData.id;
    dataBody.estado = this.otroProductoData.estado;
    dataBody.otprEmpresaId = this.otroProductoData.otprEmpresaId;
    dataBody.fechaCreacion = this.otroProductoData.fechaCreacion;
    dataBody.fechaModificacion = this.otroProductoData.fechaModificacion;

    this.otroProductoService.actualizarOtroProucto(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.otroProductoFormGroup.disable();
          this.edicionOtroProducto = false;
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
