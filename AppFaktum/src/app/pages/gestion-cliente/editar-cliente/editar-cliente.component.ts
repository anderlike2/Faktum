import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ICliente } from 'src/app/models/cliente.model';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursalCliente } from 'src/app/models/sucursal-cliente.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ClienteService } from 'src/app/services/cliente-service/cliente.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { CrearContratoClienteComponent } from '../../modals/crear-contrato-cliente/crear-contrato-cliente.component';
import { CrearSucursalClienteComponent } from '../../modals/crear-sucursal-cliente/crear-sucursal-cliente.component';

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
  listSucursalesCliente: ISucursalCliente[] = [];
  listContratosCliente: IContratoCliente[] = [];

  clienteCollapsed: boolean = true;
  sucursalClienteCollapsed: boolean = true;
  contratoCollapsed: boolean = true;

  colsSucursalesCliente: any[] = [
    { field: 'suclNombre', header: 'Nombre' },
    { field: 'suclCodigo', header: 'Código' },
    { field: 'suclContacto', header: 'Contacto' },
    { field: 'suclCorreo', header: 'Correo' },
    { field: 'suclDiasPago', header: 'Días pago' },
    { field: 'suclTelefono', header: 'Teléfono' }
  ];
  seletedSucursalCliente: any;

  colsContratosCliente: any[] = [
    { field: 'cosaContrato', header: 'Contrato' },
    { field: 'cosaNitCliente', header: 'Nit Cliente' },
    { field: 'cosaPoliza', header: 'Póliza' }
  ];
  seletedContratoCliente: any;

  constructor(private cargueCombosService: CargueCombosService, private clienteService: ClienteService,
    private sharedService: SharedService, private generalService: GeneralService, private router: Router,
    private modalService: NgbModal) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.clienteEmpresaDataListener$.subscribe({
      next: (data) => {
        this.informacionCliente = data;
      }
    });

    this.initForm();
    this.cargarComboListas();
    this.cargarInformacionCliente(this.informacionCliente.id);
    this.cargarInformacionSucursalesCliente(this.informacionCliente.id);
    this.cargarInformacionContratosCliente(this.informacionCliente.id);
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      primerNombre: [ { value: '', disabled: false }, [  ] ],
      segundoNombre: [ { value: '', disabled: false }, [  ] ],
      apellidos: [ { value: '', disabled: false }, [  ] ],
      nit: [ { value: '', disabled: false }, [  ] ],
      dv: [ { value: '', disabled: false }, [  ] ],
      ciuu: [ { value: '', disabled: false }, [  ] ],
      celular: [ { value: '', disabled: false }, [  ] ],
      telefonoFijo: [ { value: '', disabled: false }, [  ] ],
      contacto: [ { value: '', disabled: false }, [  ] ],
      correo: [ { value: '', disabled: false }, [  ] ],
      correoFacturacion: [ { value: '', disabled: false }, [  ] ],
      paginaWeb: [ { value: '', disabled: false }, [  ] ],
      direccion: [ { value: '', disabled: false }, [  ] ],
      cobertura: [ { value: '', disabled: false }, [  ] ],
      descGlobal: [ { value: '', disabled: false }, [  ] ],
      diasPago: [ { value: '', disabled: false }, [  ] ],
      estadoOperacion: [ { value: '', disabled: false }, [  ] ],
      juridica: [ { value: '', disabled: false }, [  ] ],
      localidad: [ { value: '', disabled: false }, [  ] ],
      idRepLegal: [ { value: '', disabled: false }, [  ] ],
      representanteLegal: [ { value: '', disabled: false }, [  ] ],
      paisId: [ { value: '', disabled: false }, [  ] ],
      deptoId: [ { value: '', disabled: false }, [  ] ],
      ciudadId: [ { value: '', disabled: false }, [  ] ],
      empresaId: [ { value: '', disabled: false }, [  ] ],
      regimenId: [ { value: '', disabled: false }, [  ] ],
      respFiscalId: [ { value: '', disabled: false }, [  ] ],
      respTributariaId: [ { value: '', disabled: false }, [  ] ],
      tipoClienteId: [ { value: '', disabled: false }, [  ] ],
      tipoIdId: [ { value: '', disabled: false }, [  ] ],
      clasJuridicaId: [ { value: '', disabled: false }, [  ] ],
      razonSocial: [ { value: '', disabled: false }, [  ] ]
    }

    this.clienteFormGroup = this.fb.group(formControls);
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

  cargarInformacionSucursalesCliente(idCliente: number): void{
    this.clienteService.obtenerInformacionSucursalesClienteId(idCliente)
    .subscribe({
      next: (response) => {
        this.listSucursalesCliente = response;
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
           this.cargarInformacionSucursalesCliente(this.informacionCliente.id);
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

  verSucursalCliente(value:ISucursalCliente): void{
    this.sharedService.addSucursalClienteData(value);
    this.router.navigate(['./gestion-sucursal-cliente/editar-sucursal-cliente']);
  }

  verContratoCliente(value:IContratoCliente): void{
    this.sharedService.addContratoClienteData(value);
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
  }

  abrirModalCrearSucursalCliente(): void {
    const modalSucursalCliente = this.modalService.open(
      CrearSucursalClienteComponent, {
        size: 'xl',
        backdrop: false
      }
    );
    modalSucursalCliente.componentInstance.clienteID = this.informacionCliente.id;
  }

}
