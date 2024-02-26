import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ICliente } from 'src/app/models/cliente.model';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ClienteService } from 'src/app/services/cliente-service/cliente.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { CrearContratoClienteComponent } from '../../modals/crear-contrato-cliente/crear-contrato-cliente.component';
import swal from 'sweetalert2';

@Component({
  selector: 'app-editar-cliente',
  templateUrl: './editar-cliente.component.html',
  styleUrls: ['./editar-cliente.component.scss']
})
export class EditarClienteComponent implements OnInit {

  clienteFormGroup: FormGroup;
  fb = new FormBuilder();

  edicionCliente: boolean = false;
  listPaises: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listCiudades: IListCombo[] = [];
  listEmpresas: IEmpresa[] = [];
  listRegimenes: IListCombo[] = [];
  listResponsabilidadesFiscales: IListCombo[] = [];
  listResponsabilidadesTributarias: IListCombo[] = [];
  listTipoClientes: IListCombo[] = [];
  listTipoIds: IListCombo[] = [];
  listClasesJuridicas: IListCombo[] = [];
  informacionCliente: ICliente;
  listContratosCliente: IContratoCliente[] = [];

  clienteCollapsed: boolean = true;
  sucursalClienteCollapsed: boolean = true;
  contratoCollapsed: boolean = true;
  seletedSucursalCliente: any;

  colsContratosCliente: any[] = [
    { field: 'cosaContrato', header: 'Contrato' },
    { field: 'cosaPoliza', header: 'Póliza' }
  ];
  seletedContratoCliente: any;

  constructor(
    private cargueCombosService: CargueCombosService,
    private clienteService: ClienteService,
    private sharedService: SharedService,
    private generalService: GeneralService,
    private router: Router,
    private modalService: NgbModal
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.editarGeneralDataListener$.subscribe({
      next: (data) => {
        this.informacionCliente = data;
      }
    });

    this.initForm();
    this.cargarComboListas();
    this.cargarInformacionCliente(this.informacionCliente.id);
    this.cargarInformacionContratosCliente(this.informacionCliente.id);
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      primerNombre: [ { value: '', disabled: false }, [  ] ],
      segundoNombre: [ { value: '', disabled: false }, [  ] ],
      apellidos: [ { value: '', disabled: false }, [  ] ],
      nit: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      dv: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      ciuu: [ { value: '', disabled: false }, [  ] ],
      celular: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      telefonoFijo: [ { value: '', disabled: false }, [  ] ],
      contacto: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      correo: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.email
       ] ],
      correoFacturacion: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.email
       ] ],
      paginaWeb: [ { value: '', disabled: false }, [  ] ],
      direccion: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      cobertura: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      descGlobal: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      diasPago: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      estadoOperacion: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      juridica: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      localidad: [ { value: '', disabled: false }, [  ] ],
      idRepLegal: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      representanteLegal: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      paisId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      deptoId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      ciudadId: [ { value: '', disabled: false }, [
        Validators.required
      ] ],
      empresaId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      regimenId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      respFiscalId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      respTributariaId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      tipoClienteId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      tipoIdId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clasJuridicaId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      razonSocial: [ { value: '', disabled: false }, [
        Validators.required
       ] ]
    }

    this.clienteFormGroup = this.fb.group(formControls);
  }

  get nitErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('nit') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get dvErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('dv') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get celularErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('celular') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get contactoErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('contacto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get correoErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('correo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('email')
      ? 'Correo no valido'
      : '';
  }

  get correoFacturacionErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('correoFacturacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('email')
      ? 'Correo no valido'
      : '';
  }

  get direccionErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('direccion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get coberturaErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('cobertura') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get descGlobalErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('descGlobal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get diasPagoErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('diasPago') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get estadoOperacionErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('estadoOperacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get juridicaErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('juridica') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get idRepLegalErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('idRepLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get representanteLegalErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('representanteLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get paisIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('paisId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get deptoIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('deptoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get ciudadIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('ciudadId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get empresaIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('empresaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get regimenIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('regimenId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get respFiscalIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('respFiscalId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get respTributariaIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('respTributariaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get tipoClienteIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('tipoClienteId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get tipoIdIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('tipoIdId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clasJuridicaIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clasJuridicaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get razonSocialErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('razonSocial') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  cargarComboListas(): void {
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.PAIS)
    .subscribe({
      next: (response) => {
        this.listPaises = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.DEPARTAMENTO)
    .subscribe({
      next: (response) => {
        this.listDeptos = response;
      }
    });
    this.cargueCombosService.obtenerEmpresas()
    .subscribe({
      next: (response) => {
        this.listEmpresas = response;
      }
    });
    this.cargueCombosService.obtenerListaRegimen()
    .subscribe({
      next: (response) => {
        this.listRegimenes = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.RESP_FISCAL)
    .subscribe({
      next: (response) => {
        this.listResponsabilidadesFiscales = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.RESP_TRIBUTARIA)
    .subscribe({
      next: (response) => {
        this.listResponsabilidadesTributarias = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_CLIENTE)
    .subscribe({
      next: (response) => {
        this.listTipoClientes = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_ID)
    .subscribe({
      next: (response) => {
        this.listTipoIds = response;
      }
    });
    this.cargueCombosService.obtenerListaClasesJuridicas()
    .subscribe({
      next: (response) => {
        this.listClasesJuridicas = response;
      }
    });
  }

  cargarInformacionCliente(idCliente: number): void{
    this.clienteService.obtenerInformacionClienteId(idCliente)
    .subscribe({
      next: (response) => {
        if(response != null){
          this.cargarCiudadesDepto(response.clieDeptoId);

          this.clienteFormGroup.patchValue({
            primerNombre: response.cliePrimerNom,
            segundoNombre: response.clieSegundoNom,
            apellidos: response.clieApellidos,
            nit: response.clieNit,
            dv: response.clieDv,
            ciuu: response.clieCiuu,
            celular: response.clieCelular,
            telefonoFijo: response.clieTelFijo,
            contacto: response.clieContacto,
            correo: response.clieCorreo,
            correoFacturacion: response.clieCorreoFact,
            paginaWeb: response.cliePaginaWeb,
            direccion: response.clieDireccion,
            cobertura: response.clieCobertura,
            descGlobal: response.clieDescGlobal,
            diasPago: response.clieDiasPago,
            estadoOperacion: response.clieEstadoOperacion,
            juridica: response.clieJuridica,
            localidad: response.clieLocalidad,
            idRepLegal: response.clieIdReprLegal,
            representanteLegal: response.clieReprLegal,
            paisId: response.cliePaisId,
            deptoId: response.clieDeptoId,
            ciudadId: response.clieCiudadId,
            empresaId: response.clieEmpresaId,
            regimenId: response.clieRegimenId,
            respFiscalId: response.clieRespFiscalId,
            respTributariaId: response.clieRespTributariaId,
            tipoClienteId: response.clieTipoClienteId,
            tipoIdId: response.clieTipoIdId,
            clasJuridicaId: response.clieClasJuridicaId,
            razonSocial: response.clieRazonSocial
          });

          this.clienteFormGroup.disable();
          this.edicionCliente = false;
        }
      }
    });
  }

  cargarInformacionContratosCliente(idCliente: number): void{
    this.clienteService.obtenerInformacionContratosClienteId(idCliente)
    .subscribe({
      next: (response) => {
        this.listContratosCliente = response;
      }
    });
  }

  editarForm(): void {
    this.clienteFormGroup.enable();
    this.edicionCliente = true;
  }

  cancelarEdicion(): void {
    this.cargarInformacionCliente(this.informacionCliente.id);
  }

  actualizarCliente(): void{
    if(this.clienteFormGroup.invalid) {
      this.clienteFormGroup.markAllAsTouched();
      return;
    }

    const formData = this.clienteFormGroup.getRawValue();

    const dataBody: ICliente = {
      id: this.informacionCliente.id,
      cliePrimerNom: formData.primerNombre,
      clieSegundoNom: formData.segundoNombre,
      clieApellidos: formData.apellidos,
      clieNit: formData.nit,
      clieDv: formData.dv,
      clieCiuu: formData.ciuu,
      clieCelular: formData.celular,
      clieTelFijo: formData.telefonoFijo,
      clieContacto: formData.contacto,
      clieCorreo: formData.correo,
      clieCorreoFact: formData.correoFacturacion,
      cliePaginaWeb: formData.paginaWeb,
      clieDireccion: formData.direccion,
      clieCobertura: formData.cobertura,
      clieDescGlobal: formData.descGlobal,
      clieDiasPago: formData.diasPago,
      clieEstadoOperacion: formData.estadoOperacion,
      clieJuridica: formData.juridica,
      clieLocalidad: formData.localidad,
      clieIdReprLegal: formData.idRepLegal,
      clieReprLegal: formData.representanteLegal,
      cliePaisId: formData.paisId,
      clieDeptoId: formData.deptoId,
      clieCiudadId: formData.ciudadId,
      clieEmpresaId: formData.empresaId,
      clieRegimenId: formData.regimenId,
      clieRespFiscalId: formData.respFiscalId,
      clieRespTributariaId: formData.respTributariaId,
      clieTipoClienteId: formData.tipoClienteId,
      clieTipoIdId: formData.tipoIdId,
      clieClasJuridicaId: formData.clasJuridicaId,
      clieRazonSocial: formData.razonSocial,
      estado: this.informacionCliente.estado,
      fechaCreacion: this.informacionCliente.fechaCreacion,
      fechaModificacion: this.informacionCliente.fechaModificacion
    }

    this.clienteService.actualizarCliente(dataBody)
    .subscribe({
      next: (response) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
           this.clienteFormGroup.disable();
           this.cargarInformacionCliente(this.informacionCliente.id);
           this.cargarInformacionContratosCliente(this.informacionCliente.id);
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

  verContratoCliente(value:IContratoCliente): void{
    this.sharedService.addEditarGeneralData(value);
    this.router.navigate(['./gestion-contrato-cliente/editar-contrato-cliente']);
  }

  abrirModalCrearContrato(): void {
    const modalCliente = this.modalService.open(
      CrearContratoClienteComponent, {
        size: 'xl',
        backdrop: false
      }
    );
    modalCliente.componentInstance.clienteID = this.informacionCliente.id;

    modalCliente.result.then((result) => {
      if (result) {
        this.cargarInformacionContratosCliente(this.informacionCliente.id);
      }
    })
  }

  alertaEliminarContratoCliente(value: IContratoCliente): void {
    swal.fire({
      title: "¿Esta seguro que desea eliminar estre registro?",
      text: "Este registro se eliminara de forma permanente",
      icon: "warning",
      showCancelButton: true,
      cancelButtonText: 'Cancelar',
      confirmButtonText: "¡Si, Eliminar!"
    }).then((result) => {
      if (result.isConfirmed) {
        this.eliminarContratoCliente(value);
      }
    });
  }

  eliminarContratoCliente(value: IContratoCliente): void {
    this.clienteService.eliminarContratoSalud(value.id).subscribe({
      next: (response) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        } else {
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
           this.cargarInformacionContratosCliente(this.informacionCliente.id);
        }
      }
    });
  }

}