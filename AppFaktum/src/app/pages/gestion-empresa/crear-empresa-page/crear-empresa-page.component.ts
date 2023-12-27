import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TipoListEnum } from 'src/app/models/enums-aplicacion.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { EmpresaService } from 'src/app/services/empresa-service/empresa.service';
import swal from 'sweetalert2';

@Component({
  selector: 'app-crear-empresa-page',
  templateUrl: './crear-empresa-page.component.html',
  styleUrls: ['./crear-empresa-page.component.scss']
})
export class CrearEmpresaPageComponent implements OnInit {

  empresaFormGroup: FormGroup;
  fb = new FormBuilder();

  listTipoId: IListCombo[] = [];
  listRespFiscal: IListCombo[] = [];
  listRespTributaria: IListCombo[] = [];
  listTipoCliente: IListCombo[] = [];
  ListRegEmpresa: IListCombo[] = [];
  listClasJuridica: IListCombo[] = [];

  empresaCollapsed: boolean = false;

  constructor(
    private empresaService: EmpresaService,
    private cargueCombosService: CargueCombosService
  ) { }

  ngOnInit(): void {
    this.initForm();
    this.cargarComboListas();
  }

  cargarComboListas(): void {

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_ID)
    .subscribe({
      next: (response) => {
        this.listTipoId = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.RESP_FISCAL)
    .subscribe({
      next: (response) => {
        this.listRespFiscal = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.RESP_TRIBUTARIA)
    .subscribe({
      next: (response) => {
        this.listRespTributaria = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_CLIENTE)
    .subscribe({
      next: (response) => {
        this.listTipoCliente = response;
      }
    });

    this.cargueCombosService.obtenerListaRegimen()
    .subscribe({
      next: (response) => {
        this.ListRegEmpresa = response;
      }
    });

    this.cargueCombosService.obtenerListaClasesJuridicas()
    .subscribe({
      next: (response) => {
        this.listClasJuridica = response;
      }
    });

  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      emprNombre: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprNit: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDv: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDepto: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprCiudad: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDireccion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprTelefono: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprMail: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprPagWeb: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRepLegal: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprIdRepLegal: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprCiuu: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprContacto: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprFormatoImpr: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprHabilitacion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLocalidad: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprObservaciones: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprPorcReteIca: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRecepcion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRegimenId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRespFiscalId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRespTributId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprTipoClienteId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprTipoIdId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLeyEnFactura: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLeyEnNotaCredito: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLeyEnNotaDebito: [
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
      emprClasJuridicaId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprCelular: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDiasPago: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ]
    };

    this.empresaFormGroup = this.fb.group(formControls);
  }

  get emprNombreErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprNombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprNitErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprNit') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprDvErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprDv') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprDeptoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprDepto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprCiudadErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprCiudad') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprDireccionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprDireccion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprTelefonoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprTelefono') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprMailErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprMail') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprPagWebErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprPagWeb') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprRepLegalErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprRepLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprIdRepLegalErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprIdRepLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprContactoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprContacto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprFormatoImprErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprFormatoImpr') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprHabilitacionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprHabilitacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprLocalidadErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprLocalidad') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprObservacionesErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprObservaciones') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprPorcReteIcaErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprPorcReteIca') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprRecepcionErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprRecepcion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprRegimenIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprRegimenId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprRespFiscalIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprRespFiscalId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprRespTributIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprRespTributId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprTipoClienteIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprTipoClienteId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprTipoIdIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprTipoIdId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprLeyEnFacturaErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprLeyEnFactura') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprLeyEnNotaCreditoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprLeyEnNotaCredito') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprLeyEnNotaDebitoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprLeyEnNotaDebito') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprFactContadorErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprFactContador') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprClasJuridicaIdErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprClasJuridicaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprCelularErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprCelular') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }
  get emprDiasPagoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprDiasPago') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }

  submitForm(): void {

    if (this.empresaFormGroup.invalid) {
      this.empresaFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IEmpresa = this.empresaFormGroup.getRawValue();
    dataBody.id = 0;
    dataBody.estado = 1;

    this.empresaService.crearEmpresa(dataBody).subscribe({
      next: (response) => {
        this.empresaFormGroup.reset();
        swal.fire(``, 'La empresa fue creada de forma exitosa.', 'success');
      }
    });

  }

}
