import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import swal from 'sweetalert2';

@Component({
  selector: 'app-crear-sucursal',
  templateUrl: './crear-sucursal.component.html',
  styleUrls: ['./crear-sucursal.component.scss']
})
export class CrearSucursalComponent implements OnInit {

  @Input() empresaID: number;

  sucursalFormGroup: FormGroup;
  fb = new FormBuilder();
  listCentroCostos: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listCiudades: IListCombo[] = [];
  listFormatosImpresion: IListCombo[] = [];

  constructor(
    private detalleEmpresaService: DetalleEmpresaService,
    private cargueCombosService: CargueCombosService,
    private modalRef: NgbActiveModal,
    private generalService: GeneralService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarListaCombox();
  }

  cargarListaCombox(): void {

    this.cargueCombosService.obtenerListaCentrosCostoEmpresa(this.empresaID)
    .subscribe({
      next: (response) => {
        this.listCentroCostos = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.DEPARTAMENTO)
    .subscribe({
      next: (response) => {
        this.listDeptos = response;
      }
    });
    this.cargueCombosService.obtenerListaFormatosImpresionEmpresa(this.empresaID)
    .subscribe({
      next: (response) => {
        this.listFormatosImpresion = response;
      }
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      sucuNombre: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      sucuDepto: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCelular: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCiudad: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCodigo: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuContacto: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuDireccion: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuEstadoOperacion: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuHabilitacion: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuLeyendaFactura: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuLeyendaNotaCredito: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuLeyendaNotaDebito: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuListPrecio: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuMail: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuObservaciones: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuReteIca: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuTelefono: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCentroCostosId: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuFormatoImpresionId: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ]
    };

    this.sucursalFormGroup = this.fb.group(formControls);
  }

  get sucuNombreErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuNombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuDeptoErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuDepto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuCelularErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuCelular') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuCiudadErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuCiudad') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuCodigoErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuContactoErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuContacto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuDireccionErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuDireccion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuEstadoOperacionErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuEstadoOperacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuHabilitacionErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuHabilitacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuLeyendaFacturaErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuLeyendaFactura') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuLeyendaNotaCreditoErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuLeyendaNotaCredito') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuLeyendaNotaDebitoErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuLeyendaNotaDebito') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuListPrecioErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuListPrecio') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuMailErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuMail') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuObservacionesErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuObservaciones') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuReteIcaErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuReteIca') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuTelefonoErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuTelefono') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuCentroCostosIdErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuCentroCostosId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get sucuFormatoImpresionIdErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuFormatoImpresionId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  guardarSucursal(): void {
    if (this.sucursalFormGroup.invalid) {
      this.sucursalFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ISucursal = this.sucursalFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;

    // toca hablar de estos dos
    dataBody.sucuEmpresaId = this.empresaID;
    dataBody.sucuFormatoImpresionId = 1;
    dataBody.sucuPrincipal = 0;

    this.detalleEmpresaService.crearSucursal(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.modalRef.close(true);
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cerrarModal(info?: any) {
    this.modalRef.close();
  }

  cargarCiudadesDepto(idDepto: number): void{
    this.cargueCombosService.obtenerListaCiudadesDepto(idDepto)
    .subscribe({
      next: (response) => {
        this.listCiudades = response;
      }})
  }

}
