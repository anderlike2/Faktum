import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { ICliente } from 'src/app/models/cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ClienteService } from 'src/app/services/cliente-service/cliente.service';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-crear-cliente',
  templateUrl: './crear-cliente.component.html',
  styleUrls: ['./crear-cliente.component.scss']
})
export class CrearClienteComponent implements OnInit {

  @Input() empresaID: number;

  clienteFormGroup: FormGroup;
  fb = new FormBuilder();

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

  clienteCollapsed: boolean = false;

  constructor(private cargueCombosService: CargueCombosService, private clienteService: ClienteService,
    private generalService: GeneralService, private modalRef: NgbActiveModal) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarComboListas();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      cliePrimerNom: [ { value: '', disabled: false }, [ ] ],
      clieSegundoNom: [ { value: '', disabled: false }, [  ] ],
      clieApellidos: [ { value: '', disabled: false }, [ ] ],
      clieNit: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      clieDv: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      clieCiuu: [ { value: '', disabled: false }, [  ] ],
      clieCelular: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieTelFijo: [ { value: '', disabled: false }, [  ] ],
      clieContacto: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieCorreo: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.email
       ] ],
      clieCorreoFact: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.email
       ] ],
      cliePaginaWeb: [ { value: '', disabled: false }, [  ] ],
      clieDireccion: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieCobertura: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieDescGlobal: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      clieDiasPago: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      clieEstadoOperacion: [ { value: '', disabled: false }, [
        Validators.required,
        Validators.pattern('[0-9]+')
       ] ],
      clieJuridica: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieLocalidad: [ { value: '', disabled: false }, [  ] ],
      clieIdReprLegal: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieReprLegal: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      cliePaisId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieDeptoId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieCiudadId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieEmpresaId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieRegimenId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieRespFiscalId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieRespTributariaId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieTipoClienteId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieTipoIdId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieClasJuridicaId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      clieRazonSocial: [ { value: '', disabled: false }, [
        Validators.required
       ] ]
    }

    this.clienteFormGroup = this.fb.group(formControls);
  }

  get clieNitErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieNit') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get clieDvErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieDv') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get clieCelularErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieCelular') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieContactoErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieContacto') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieCorreoErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieCorreo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('email')
      ? 'Correo no valido'
      : '';;
  }

  get clieCorreoFactErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieCorreoFact') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('email')
      ? 'Correo no valido'
      : '';
  }

  get clieDireccionErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieDireccion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieCoberturaErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieCobertura') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieDescGlobalErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieDescGlobal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get clieDiasPagoErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieDiasPago') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get clieEstadoOperacionErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieEstadoOperacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : form.hasError('pattern')
      ? 'Este campo sólo acepta números enteros'
      : '';
  }

  get clieJuridicaErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieJuridica') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieIdReprLegalErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieIdReprLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieReprLegalErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieReprLegal') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get cliePaisIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('cliePaisId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieDeptoIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieDeptoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieCiudadIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieCiudadId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieEmpresaIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieEmpresaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieRegimenIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieRegimenId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieRespFiscalIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieRespFiscalId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieRespTributariaIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieRespTributariaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieTipoClienteIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieTipoClienteId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieTipoIdIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieTipoIdId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieClasJuridicaIdErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieClasJuridicaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get clieRazonSocialErrorMensaje(): string {
    const form: AbstractControl = this.clienteFormGroup.get('clieRazonSocial') as AbstractControl;
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

  cargarCiudadesDepto(idDepto: number): void{
    this.cargueCombosService.obtenerListaCiudadesDepto(idDepto)
    .subscribe({
      next: (response) => {
        this.listCiudades = response;
      }})
  }

  guardarCliente(): void {
    if (this.clienteFormGroup.invalid) {
      this.clienteFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ICliente = this.clienteFormGroup.getRawValue();
    dataBody.id = 0;
    dataBody.estado = 1;

    dataBody.clieEmpresaId = this.empresaID;

    this.clienteService.crearCliente(dataBody).subscribe({
      next: (response) => {
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
