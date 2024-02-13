import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IResolucion } from 'src/app/models/resolucion.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ResolucionService } from 'src/app/services/resolucion-service/resolucion.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import swal from 'sweetalert2';
import { AsociarResolucionSucursalComponent } from '../../modals/asociar-resolucion-sucursal/asociar-resolucion-sucursal.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

@Component({
  selector: 'app-editar-sucursal',
  templateUrl: './editar-sucursal.component.html',
  styleUrls: ['./editar-sucursal.component.scss']
})
export class EditarSucursalComponent implements OnInit {

  sucursalCollapsed: boolean = true;
  edicionSucursal: boolean = false;
  resolucionCollapsed: boolean = true;

  sucursalData: ISucursal;

  sucursalFormGroup: FormGroup;
  fb = new FormBuilder();

  listCentroCostos: IListCombo[] = [];
  listFormatosImpresion: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listCiudades: IListCombo[] = [];
  listResolucionesSucursal: IResolucion[] = [];

  seletedResolucionSucursal: any;

  colsResolucionesSucursal: any[] = [
    { field: 'resoAnio', header: 'Año' },
    { field: 'resoConsActual', header: 'Cons. Actual' },
    { field: 'resoConsFinal', header: 'Cons. Final' },
    { field: 'resoConsInicial', header: 'Cons. Inicial' },
    { field: 'resoVigencia', header: 'Fecha Vigencia' },
    { field: 'resoCodigo', header: 'Código' },
    { field: 'resoNumeracionActual', header: 'Numeración Actual' }
  ];

  constructor(
    private detalleEmpresaService: DetalleEmpresaService,
    private cargueCombosService: CargueCombosService,
    private sharedService: SharedService,
    private generalService: GeneralService,
    private resolucionService: ResolucionService,
    private modalService: NgbModal,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {

    this.sharedService.sucursalEmpresaDataListener$.subscribe({
      next: (data) => {
        this.sucursalData = data;
      }
    });

    this.initForm();
    this.cargarListaCombox();
    this.cargarInformacionResolucionesSucursal(this.sucursalData.id);

    if(this.sucursalData.sucuDepto != undefined && this.sucursalData.sucuDepto != null && this.sucursalData.sucuDepto != "")
            this.cargarCiudadesDepto(Number(this.sucursalData.sucuDepto));

    this.cargarDataForm();
  }

  cargarListaCombox(): void {

    this.cargueCombosService.obtenerListaCentrosCostoEmpresa(this.sucursalData.sucuEmpresaId)
    .subscribe({
      next: (response) => {
        this.listCentroCostos = response;
      }
    });
    this.cargueCombosService.obtenerListaFormatosImpresionEmpresa(this.sucursalData.sucuEmpresaId)
    .subscribe({
      next: (response) => {
        this.listFormatosImpresion = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.DEPARTAMENTO)
    .subscribe({
      next: (response) => {
        this.listDeptos = response;
      }
    });
  }

  cargarDataForm(): void {
    this.sucursalFormGroup.disable();
    this.edicionSucursal = false;
    this.sucursalFormGroup.patchValue(
      this.sucursalData
    );
  }

  editarForm(): void {
    this.sucursalFormGroup.enable();
    this.edicionSucursal = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm();
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
      sucuCentroCosto: [ { value: '', disabled: false }, [
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

  get sucuCentroCostoErrorMensaje(): string {
    const form: AbstractControl = this.sucursalFormGroup.get('sucuCentroCosto') as AbstractControl;
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

    dataBody.id = this.sucursalData.id;
    dataBody.estado = this.sucursalData.estado;

    // toca hablar de estos dos
    dataBody.sucuEmpresaId = this.sucursalData.sucuEmpresaId;
    dataBody.sucuFormatoImpresionId = this.sucursalData.sucuFormatoImpresionId;
    dataBody.sucuPrincipal = this.sucursalData.sucuPrincipal;
    dataBody.fechaCreacion = this.sucursalData.fechaCreacion;
    dataBody.fechaModificacion = this.sucursalData.fechaModificacion;

    this.detalleEmpresaService.actualizarSucursal(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.sucursalFormGroup.disable();
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cargarCiudadesDepto(idDepto: number): void{
    this.cargueCombosService.obtenerListaCiudadesDepto(idDepto)
    .subscribe({
      next: (response) => {
        this.listCiudades = response;
      }})
  }

  cargarInformacionResolucionesSucursal(idSucursal: number): void{
    this.resolucionService.obtenerResolucionesPorSucursalId(idSucursal)
    .subscribe({
      next: (response) => {
        this.listResolucionesSucursal = response;
      }
    });
  }

  abrirModalCrearResolucionSucursal(): void {
    const modalCliente = this.modalService.open(
      AsociarResolucionSucursalComponent, {
        size: 'xl',
        backdrop: false
      }
    );
    modalCliente.componentInstance.sucursalID = this.sucursalData.id;

    modalCliente.result.then((result) => {
      if (result) {
        this.init();
      }
    })
  }

  verResolucionSucursal(value:IResolucion): void{
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['./gestion-resolucion-sucursal/editar-resolucion-sucursal']);
  }

}
