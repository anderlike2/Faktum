import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IResolucion } from 'src/app/models/resolucion.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ResolucionService } from 'src/app/services/resolucion-service/resolucion.service';

@Component({
  selector: 'app-crear-resolucion',
  templateUrl: './crear-resolucion.component.html',
  styleUrls: ['./crear-resolucion.component.scss']
})
export class CrearResolucionComponent implements OnInit {

  @Input() empresaID: number;

  resolucionFormGroup: FormGroup;
  fb = new FormBuilder();

  listaTipoDocs: IListCombo[] = [];

  constructor(private cargueCombosService: CargueCombosService, private resolucionService: ResolucionService,
    private generalService: GeneralService, private modalRef: NgbActiveModal) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarListaCombox();
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

  cargarListaCombox(): void {
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_DOC_ELECTR)
    .subscribe({
      next: (response) => {
        this.listaTipoDocs = response;
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

  guardarResolucion(): void {
    if (this.resolucionFormGroup.invalid) {
      this.resolucionFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IResolucion = this.resolucionFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.resoEmpresaId = this.empresaID;

    this.resolucionService.crearResolucion(dataBody).subscribe({
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
