import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IEmpresa } from 'src/app/models/empresa.model';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { Observable } from 'rxjs';
import { IListCombo } from 'src/app/models/general.model';
import { TipoListEnum } from 'src/app/models/enums-aplicacion.model';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import swal from 'sweetalert2';
import { IClienteEmpresa } from 'src/app/models/cliente-empresa.model';
import { ISucursalEmpresa } from 'src/app/models/sucursal-empresa.model';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CrearSucursalComponent } from '../../modals/crear-sucursal/crear-sucursal.component';
import { Router } from '@angular/router';
import { ISucursal } from 'src/app/models/sucursal.model';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { LoaderService } from 'src/app/services/loader-service/loader.service';
import { CrearClienteComponent } from '../../modals/crear-cliente/crear-cliente.component';
import { ICentroCostos } from 'src/app/models/centro-costos.model';
import { CrearCentroCostosComponent } from '../../modals/crear-centro-costos/crear-centro-costos.component';
import { CentroCostosService } from 'src/app/services/centro-costos-service/centro-costos.service';
import { CrearFormatoImpresionComponent } from '../../modals/crear-formato-impresion/crear-formato-impresion.component';
import { IFormatoImpresion } from 'src/app/models/formato-impresion.model';
import { FormatoImpresionService } from 'src/app/services/formato-impresion-service/formato-impresion.service';
import { IUnidad } from 'src/app/models/unidad.model';
import { UnidadService } from 'src/app/services/unidad-service/unidad.service';
import { CrearUnidadComponent } from '../../modals/crear-unidad/crear-unidad.component';
import { IProducto } from 'src/app/models/producto.model';
import { CrearProductoComponent } from '../../modals/crear-producto/crear-producto.component';
import { ProductoService } from 'src/app/services/producto-service/producto.service';

@Component({
  selector: 'app-detalle-empresa',
  templateUrl: './detalle-empresa.component.html',
  styleUrls: ['./detalle-empresa.component.scss']
})
export class DetalleEmpresaComponent implements OnInit {

  empresaFormGroup: FormGroup;
  fb = new FormBuilder();

  listTipoId: IListCombo[] = [];
  listRespFiscal: IListCombo[] = [];
  listRespTributaria: IListCombo[] = [];
  listTipoCliente: IListCombo[] = [];
  ListRegEmpresa: IListCombo[] = [];
  listClasJuridica: IListCombo[] = [];
  edicionEmpresa: boolean = false;

  dataEmpresa: IEmpresa;

  empresaCollapsed: boolean = false;

  constructor(
    private storageService: StorageService,
    private cargueCombosService: CargueCombosService,
    private detalleEmpresaService: DetalleEmpresaService,
    private centroCostosService: CentroCostosService,
    private sharedService: SharedService,
    private modalService: NgbModal,
    private router: Router,
    private formatoImpresionService: FormatoImpresionService,
    private unidadService: UnidadService,
    private productoService: ProductoService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarComboListas();
    this.cargarInfoEmpresa();
    this.cargarTablas();
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

  cargarTablas(): void {

  }

  cargarInfoEmpresa(): void {

    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();

    if (this.dataEmpresa) {

      this.empresaFormGroup.patchValue({
        nombre: this.dataEmpresa.emprNombre,
        nit: this.dataEmpresa.emprNit,
        dv: this.dataEmpresa.emprDv,
        departamento: this.dataEmpresa.emprDepto,
        ciudad: this.dataEmpresa.emprCiudad,
        direccion: this.dataEmpresa.emprDireccion,
        telefono: this.dataEmpresa.emprTelefono,
        correo: this.dataEmpresa.emprMail,
        paginaWeb: this.dataEmpresa.emprPagWeb,
        repLegal: this.dataEmpresa.emprRepLegal,
        docRepLegal: this.dataEmpresa.emprIdRepLegal,
        empreCiuu: this.dataEmpresa.emprCiuu,
        contacto: this.dataEmpresa.emprContacto,
        formatoImp: this.dataEmpresa.emprFormatoImpr,
        empreHabilitacion: this.dataEmpresa.emprHabilitacion,
        empreLocalidad: this.dataEmpresa.emprLocalidad,
        observacion: this.dataEmpresa.emprObservaciones,
        porcRetIca: this.dataEmpresa.emprPorcReteIca,
        recepcion: this.dataEmpresa.emprRecepcion,
        regimenId: this.dataEmpresa.emprRegimenId,
        respFiscalId: this.dataEmpresa.emprRespFiscalId,
        respTributId: this.dataEmpresa.emprRespTributId,
        tipoClienteId: this.dataEmpresa.emprTipoClienteId,
        tipoId: this.dataEmpresa.emprTipoIdId,
        leyEnFactura: this.dataEmpresa.emprLeyEnFactura,
        leyEnNotaCredito: this.dataEmpresa.emprLeyEnNotaCredito,
        leyEnNotaDebito: this.dataEmpresa.emprLeyEnNotaDebito,
        emprClasJuridicaId: this.dataEmpresa.emprClasJuridicaId,
        emprCelular: this.dataEmpresa.emprCelular,
        emprDiasPago: this.dataEmpresa.emprDiasPago,
        emprFactContador: this.dataEmpresa.emprFactContador,
      });

      this.empresaFormGroup.disable();
      this.edicionEmpresa = false;

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
          Validators.required,
          Validators.pattern('[0-9]+')
        ]
      ],
      dv: [
        { value: '', disabled: false },
        [
          Validators.required,
          Validators.pattern('[0-9]+')
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
          Validators.required,
          Validators.email
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
          Validators.required,
          Validators.pattern('[0-9]+')
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
          Validators.required,
          Validators.pattern('[0-9]+')
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
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get dvErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('dv') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
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
      ? 'Campo obligatorio'
      : form.hasError('email')
      ? 'Correo no valido'
      : '';
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
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get emprClasJuridicaErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprClasJuridicaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get emprCelularErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprCelular') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get emprDiasPagoErrorMensaje(): string {
    const form: AbstractControl = this.empresaFormGroup.get('emprDiasPago') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  editarForm(): void {
    this.empresaFormGroup.enable();
    this.edicionEmpresa = true;
  }

  cancelarEdicion(): void {
    this.cargarInfoEmpresa();
  }

  actualizarEmpresa(): void {
    if(this.empresaFormGroup.invalid) {
      this.empresaFormGroup.markAllAsTouched();
      return;
    }

    const formData = this.empresaFormGroup.getRawValue();

    const dataBody: IEmpresa = {
      id: this.dataEmpresa.id,
      emprNombre: formData.nombre,
      emprNit: formData.nit,
      emprDv: formData.dv,
      emprDepto: formData.departamento,
      emprCiudad: formData.ciudad,
      emprDireccion: formData.direccion,
      emprTelefono: formData.telefono,
      emprMail: formData.correo,
      emprPagWeb: formData.paginaWeb,
      emprRepLegal: formData.repLegal,
      emprIdRepLegal: formData.docRepLegal,
      emprCiuu: formData.empreCiuu,
      emprContacto: formData.contacto,
      emprFormatoImpr: formData.formatoImp,
      emprHabilitacion: formData.empreHabilitacion,
      emprLocalidad: formData.empreLocalidad,
      emprObservaciones: formData.observacion,
      emprPorcReteIca: formData.porcRetIca,
      emprRecepcion: formData.recepcion,
      emprRegimenId: formData.regimenId,
      emprRespFiscalId: formData.respFiscalId,
      emprRespTributId: formData.respTributId,
      emprTipoClienteId: formData.tipoClienteId,
      emprTipoIdId: formData.tipoId,
      emprLeyEnFactura: formData.leyEnFactura,
      emprLeyEnNotaCredito: formData.leyEnNotaCredito,
      emprLeyEnNotaDebito: formData.leyEnNotaDebito,
      emprFactContador: formData.emprFactContador,
      emprClasJuridicaId: formData.emprClasJuridicaId,
      emprCelular: formData.emprCelular,
      emprDiasPago: formData.emprDiasPago,
      estado: this.dataEmpresa.estado,
      fechaCreacion: this.dataEmpresa.fechaCreacion,
      fechaModificacion: this.dataEmpresa.fechaModificacion
    };

    this.detalleEmpresaService.actualizarEmpresa(dataBody)
    .subscribe({
      next: (response) => {
        this.empresaFormGroup.disable();
        this.storageService.setEmpresaActivaStorage(dataBody);
        swal.fire(``, response.message, 'success');
      }
    });

  }

}
