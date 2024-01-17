import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IResolucion } from 'src/app/models/resolucion.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ResolucionService } from 'src/app/services/resolucion-service/resolucion.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Component({
  selector: 'app-editar-resolucion',
  templateUrl: './editar-resolucion.component.html',
  styleUrls: ['./editar-resolucion.component.scss']
})
export class EditarResolucionComponent implements OnInit {

  resolucionCollapsed: boolean = false;
  edicionResolucion: boolean = false;

  resolucionData: IResolucion;

  resolucionFormGroup: FormGroup;
  fb = new FormBuilder();

  listaTipoDocs: IListCombo[] = [];

  constructor(private sharedService: SharedService, private resolucioService: ResolucionService, private generalService: GeneralService,
    private cargueCombosService: CargueCombosService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.resolucionListener$.subscribe(this.obtenerResolucion.bind(this));
    this.cargarListaCombox();
    this.initForm();
  }

  cargarListaCombox(): void {
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_DOC_ELECTR)
    .subscribe({
      next: (response) => {
        this.listaTipoDocs = response;
      }
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      resoAnio: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoEstadoOperacion: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoTipoDocId: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoConsActual: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoConsInicial: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoConsFinal: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoPrefijo: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoCodigo: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoNumeracionActual: [ { value: '', disabled: false }, [ Validators.required ] ],
      resoFechaExpide: [ { value: new Date(), disabled: false }, [ Validators.required ] ],
      resoVigencia: [ { value: new Date(), disabled: false }, [ Validators.required ] ]
    };

    this.resolucionFormGroup = this.fb.group(formControls);
  }

  obtenerResolucion(data: IResolucion): void {
    this.resolucioService.obtenerResolucionPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.resolucionData = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  cargarDataForm(data: IResolucion): void {
    this.resolucionFormGroup.disable();
    this.edicionResolucion = false;
    this.resolucionFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.resolucionFormGroup.enable();
    this.edicionResolucion = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.resolucionData);
  }

  guardarResolucion(): void {
    if (this.resolucionFormGroup.invalid) {
      this.resolucionFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IResolucion = this.resolucionFormGroup.getRawValue();

    dataBody.id = this.resolucionData.id;
    dataBody.estado = this.resolucionData.estado;
    dataBody.resoEmpresaId = this.resolucionData.resoEmpresaId;
    dataBody.fechaCreacion = this.resolucionData.fechaCreacion;
    dataBody.fechaModificacion = this.resolucionData.fechaModificacion;

    this.resolucioService.actualizarResolucion(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.resolucionFormGroup.disable();
          this.edicionResolucion = false;
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  get resoAnioErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoAnio') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoEstadoOperacionErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoEstadoOperacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoTipoDocIdErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoTipoDocId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoConsActualErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoConsActual') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoConsInicialErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoConsInicial') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoConsFinalErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoConsFinal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoPrefijoErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoPrefijo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoCodigoErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get resoNumeracionActualErrorMensaje(): string {
    const form: AbstractControl = this.resolucionFormGroup.get('resoNumeracionActual') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

}
