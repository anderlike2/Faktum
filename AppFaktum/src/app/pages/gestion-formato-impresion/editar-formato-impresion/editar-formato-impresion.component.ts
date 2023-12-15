import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IFormatoImpresion } from 'src/app/models/formato-impresion.model';
import { FormatoImpresionService } from 'src/app/services/formato-impresion-service/formato-impresion.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Component({
  selector: 'app-editar-formato-impresion',
  templateUrl: './editar-formato-impresion.component.html',
  styleUrls: ['./editar-formato-impresion.component.scss']
})
export class EditarFormatoImpresionComponent implements OnInit {

  formatoImpresionCollapsed: boolean = false;
  edicionFormatoImpresion: boolean = false;

  formatoImpresionData: IFormatoImpresion;

  formatoImpresionFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor( private formatoImpresionService: FormatoImpresionService,
    private sharedService: SharedService,
    private generalService: GeneralService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.formatoImpresionDataListener$.subscribe(this.obtenerFormatoImpresion.bind(this));
    this.initForm();
  }

  obtenerFormatoImpresion(data: IFormatoImpresion): void {
    this.formatoImpresionService.obtenerFormatoImpresionPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.formatoImpresionData = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      formNombre: [ { value: '', disabled: false }, [ Validators.required ] ],
      formCodigo: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.formatoImpresionFormGroup = this.fb.group(formControls);
  }

  cargarDataForm(data: IFormatoImpresion): void {
    this.formatoImpresionFormGroup.disable();
    this.edicionFormatoImpresion = false;
    this.formatoImpresionFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.formatoImpresionFormGroup.enable();
    this.edicionFormatoImpresion = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.formatoImpresionData);
  }

  guardarFormatoImpresion(): void {
    if (this.formatoImpresionFormGroup.invalid) {
      this.formatoImpresionFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IFormatoImpresion = this.formatoImpresionFormGroup.getRawValue();

    dataBody.id = this.formatoImpresionData.id;
    dataBody.estado = this.formatoImpresionData.estado;
    dataBody.formEmpresaId = this.formatoImpresionData.formEmpresaId;
    dataBody.fechaCreacion = this.formatoImpresionData.fechaCreacion;
    dataBody.fechaModificacion = this.formatoImpresionData.fechaModificacion;

    this.formatoImpresionService.actualizarFormatoImpresion(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.formatoImpresionFormGroup.disable();
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
