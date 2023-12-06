import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { TipoListEnum } from 'src/app/models/detalle-empresa.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IListCombo } from 'src/app/models/general.model';
import { ICliente } from 'src/app/models/cliente.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ClienteService } from 'src/app/services/cliente-service/cliente.service';

@Component({
  selector: 'app-detalle-cliente',
  templateUrl: './detalle-cliente.component.html',
  styleUrls: ['./detalle-cliente.component.scss']
})
export class DetalleClienteComponent implements OnInit {

  clienteFormGroup: FormGroup;
  fb = new FormBuilder();

  edicionCliente: boolean = false;
  listPaises: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listEmpresas: IEmpresa[] = [];
  listRegimenes: IListCombo[] = [];
  listResponsabilidadesFiscales: IListCombo[] = [];
  listResponsabilidadesTributarias: IListCombo[] = [];
  listTipoClientes: IListCombo[] = [];
  listTipoIds: IListCombo[] = [];
  listClasesJuridicas: IListCombo[] = [];
  informacionCliente: ICliente;

  constructor(private cargueCombosService: CargueCombosService, private clienteService: ClienteService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarComboListas();
    this.cargarInformacionCliente(3);
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

  
  editarForm(): void {
    this.clienteFormGroup.enable();
    this.edicionCliente = true;
  }

}
