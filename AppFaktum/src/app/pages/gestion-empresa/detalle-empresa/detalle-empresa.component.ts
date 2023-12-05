import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IEmpresa } from 'src/app/models/empresa.model';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-detalle-empresa',
  templateUrl: './detalle-empresa.component.html',
  styleUrls: ['./detalle-empresa.component.scss']
})
export class DetalleEmpresaComponent implements OnInit {

  empresaFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(
    private storageService: StorageService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarInfoEmpresa();
  }

  cargarInfoEmpresa(): void {

    const dataEmpresa: IEmpresa = this.storageService.getEmpresaActivaStorage();

    if (dataEmpresa) {

      this.empresaFormGroup.patchValue({
        nombre: dataEmpresa.emprNombre,
        nit: dataEmpresa.emprNit,
        dv: dataEmpresa.emprDv,
        departamento: dataEmpresa.emprDepto,
        ciudad: dataEmpresa.emprCiudad,
        direccion: dataEmpresa.emprDireccion,
        telefono: dataEmpresa.emprTelefono,
        correo: dataEmpresa.emprMail,
        paginaWeb: dataEmpresa.emprPagWeb,
        repLegal: dataEmpresa.emprRepLegal,
        docRepLegal: dataEmpresa.emprIdRepLegal,
        empreCiuu: dataEmpresa.emprCiuu,
        contacto: dataEmpresa.emprContacto
      });

    }

  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      nombre: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      nit: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      dv: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      departamento: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      ciudad: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      direccion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      telefono: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      correo: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      paginaWeb: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      repLegal: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      docRepLegal: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      empreCiuu: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      contacto: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      formatoImp: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      empreHabilitacion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      empreLocalidad: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      observacion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      porcRetIca: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      recepcion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      regimenId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      respFiscalId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      respTributId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      tipoClienteId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      tipoId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      leyEnFactura: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      leyEnNotaCredito: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      leyEnNotaDebito: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprFactContador: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      estado: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      fechaCreacion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      fechaModificacion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ]
    };

    this.empresaFormGroup = this.fb.group(formControls);
  }

  get nombreErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('nombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get nitErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('nit') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get dvErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('dv') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get departamentoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('departamento') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get ciudadErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('ciudad') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get direccionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('direccion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get telefonoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('telefono') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get correoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('correo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get paginaWebErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('paginaWeb') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get repLegalErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('repLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get docRepLegalErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('docRepLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get empreCiuuErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('empreCiuu') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get contactoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('contacto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get formatoImpErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('formatoImp') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get empreHabilitacionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('empreHabilitacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get empreLocalidadErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('empreLocalidad') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get observacionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('observacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get porcRetIcaErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('porcRetIca') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get recepcionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('recepcion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get regimenIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('regimenId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get respFiscalIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('respFiscalId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get respTributIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('respTributId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get tipoClienteIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('tipoClienteId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get tipoIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('tipoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get leyEnFacturaErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('leyEnFactura') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get leyEnNotaCreditoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('leyEnNotaCredito') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get leyEnNotaDebitoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('leyEnNotaDebito') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get emprFactContadorErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprFactContador') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get estadoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('estado') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get fechaCreacionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('fechaCreacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get fechaModificacionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('fechaModificacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }



}
