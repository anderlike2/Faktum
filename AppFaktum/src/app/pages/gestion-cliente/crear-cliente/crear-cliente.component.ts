import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
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
  
  clienteFormGroup: FormGroup;
  fb = new FormBuilder();

  listPaises: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listEmpresas: IEmpresa[] = [];
  listRegimenes: IListCombo[] = [];
  listResponsabilidadesFiscales: IListCombo[] = [];
  listResponsabilidadesTributarias: IListCombo[] = [];
  listTipoClientes: IListCombo[] = [];
  listTipoIds: IListCombo[] = [];
  listClasesJuridicas: IListCombo[] = [];

  clienteCollapsed: boolean = false;

  constructor(private cargueCombosService: CargueCombosService, private clienteService: ClienteService,
    private generalService: GeneralService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarComboListas();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      cliePrimerNom: [ { value: '', disabled: false }, [  ] ],
      clieSegundoNom: [ { value: '', disabled: false }, [  ] ],
      clieApellidos: [ { value: '', disabled: false }, [  ] ],
      clieNit: [ { value: '', disabled: false }, [  ] ],
      clieDv: [ { value: '', disabled: false }, [  ] ],
      clieCiuu: [ { value: '', disabled: false }, [  ] ],
      clieCelular: [ { value: '', disabled: false }, [  ] ],
      clieTelFijo: [ { value: '', disabled: false }, [  ] ],
      clieContacto: [ { value: '', disabled: false }, [  ] ],
      clieCorreo: [ { value: '', disabled: false }, [  ] ],
      clieCorreoFact: [ { value: '', disabled: false }, [  ] ],
      cliePaginaWeb: [ { value: '', disabled: false }, [  ] ],
      clieDireccion: [ { value: '', disabled: false }, [  ] ],
      clieCobertura: [ { value: '', disabled: false }, [  ] ],
      clieDescGlobal: [ { value: '', disabled: false }, [  ] ],
      clieDiasPago: [ { value: '', disabled: false }, [  ] ],
      clieEstadoOperacion: [ { value: '', disabled: false }, [  ] ],
      clieJuridica: [ { value: '', disabled: false }, [  ] ],
      clieLocalidad: [ { value: '', disabled: false }, [  ] ],
      clieIdReprLegal: [ { value: '', disabled: false }, [  ] ],      
      clieReprLegal: [ { value: '', disabled: false }, [  ] ],
      cliePaisId: [ { value: '', disabled: false }, [  ] ],
      clieDeptoId: [ { value: '', disabled: false }, [  ] ],
      clieCiudadId: [ { value: '', disabled: false }, [  ] ],
      clieEmpresaId: [ { value: '', disabled: false }, [  ] ],
      clieRegimenId: [ { value: '', disabled: false }, [  ] ],
      clieRespFiscalId: [ { value: '', disabled: false }, [  ] ],
      clieRespTributariaId: [ { value: '', disabled: false }, [  ] ],
      clieTipoClienteId: [ { value: '', disabled: false }, [  ] ],
      clieTipoIdId: [ { value: '', disabled: false }, [  ] ],
      clieClasJuridicaId: [ { value: '', disabled: false }, [  ] ],
      clieRazonSocial: [ { value: '', disabled: false }, [  ] ]
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

  submitForm(): void {
    if (this.clienteFormGroup.invalid) {
      this.clienteFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ICliente = this.clienteFormGroup.getRawValue();
    dataBody.id = 0;
    dataBody.estado = 1;

    this.clienteService.crearCliente(dataBody).subscribe({
      next: (response) => {        
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
           this.clienteFormGroup.reset();
        }
      }
    });

  }

}
