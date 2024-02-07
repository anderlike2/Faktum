import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { map } from 'rxjs/operators';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ClienteService } from 'src/app/services/cliente-service/cliente.service';
import { ContratoClienteService } from 'src/app/services/contrato-cliente-service/contrato-cliente.service';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Component({
  selector: 'app-editar-contrato-cliente',
  templateUrl: './editar-contrato-cliente.component.html',
  styleUrls: ['./editar-contrato-cliente.component.scss']
})
export class EditarContratoClienteComponent implements OnInit {

  contratoCollapsed: boolean = false;
  edicionContratoCliente: boolean = false;

  contratoClienteData: IContratoCliente;

  contratoClienteFormGroup: FormGroup;
  fb = new FormBuilder();

  listaCobertura: IListCombo[] = [];
  listaEmpresas: IListCombo[] = [];
  listaModalidadPago: IListCombo[] = [];
  nombreCliente: string;
  apellidoCliente: string;
  nitCliente: string;
  idEmpresaCliente: number;

  constructor(
    private contratoClienteService: ContratoClienteService,
    private cargueCombosService: CargueCombosService,
    private sharedService: SharedService,
    private generalService: GeneralService,
    private clienteService: ClienteService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {

    this.sharedService.editarGeneralDataListener$.subscribe(this.obtenerContratoCliente.bind(this));

    this.initForm();
    this.cargarListaCombox();
  }

  cargarListaCombox(): void {

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.COBERTURA)
    .subscribe({
      next: (response) => {
        this.listaCobertura = response;
      }
    });

    this.cargueCombosService.obtenerEmpresas()
    .pipe(
      map((response: IEmpresa[]) =>
        response.map((empresa: IEmpresa) => ({
          valor: empresa.id,
          nombre: empresa.emprNombre,
          codigo: empresa.emprCiuu
        })) as IListCombo[]
      )
    )
    .subscribe({
      next: (response) => {
        this.listaEmpresas = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.MODALIDAD_PAGO)
    .subscribe({
      next: (response) => {
        this.listaModalidadPago = response;
      }
    });

  }

  obtenerContratoCliente(data: IContratoCliente): void {
    this.contratoClienteService.obtenerContratoCliente(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.contratoClienteData = response.data;
          this.cargarInformacionCliente(response.data.cosaClieId);
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  cargarDataForm(data: IContratoCliente): void {
    this.contratoClienteFormGroup.disable();
    this.edicionContratoCliente = false;
    this.contratoClienteFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.contratoClienteFormGroup.enable();
    this.edicionContratoCliente = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.contratoClienteData);
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      cosaContrato: [ { value: '', disabled: false }, [
        Validators.required
        ]
      ],
      cosaPoliza: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      cosaCobeId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      cosaMopaId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ]
    };

    this.contratoClienteFormGroup = this.fb.group(formControls);
  }

  get cosaContratoErrorMensaje(): string {
    const form: AbstractControl = this.contratoClienteFormGroup.get('cosaContrato') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }

  get cosaPolizaErrorMensaje(): string {
    const form: AbstractControl = this.contratoClienteFormGroup.get('cosaPoliza') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }

  get cosaCobeIdErrorMensaje(): string {
    const form: AbstractControl = this.contratoClienteFormGroup.get('cosaCobeId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }

  get cosaMopaIdErrorMensaje(): string {
    const form: AbstractControl = this.contratoClienteFormGroup.get('cosaMopaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }


  guardarContratoCliente(): void {
    if (this.contratoClienteFormGroup.invalid) {
      this.contratoClienteFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IContratoCliente = this.contratoClienteFormGroup.getRawValue();

    dataBody.id = this.contratoClienteData.id;
    dataBody.estado = this.contratoClienteData.estado;

    // toca hablar de estos dos
    dataBody.cosaClieId = this.contratoClienteData.cosaClieId;
    dataBody.cosaEmpresaId = this.idEmpresaCliente;
    dataBody.fechaCreacion = this.contratoClienteData.fechaCreacion;
    dataBody.fechaModificacion = this.contratoClienteData.fechaModificacion;

    this.contratoClienteService.actualizarContratoCliente(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.contratoClienteFormGroup.disable();
          this.edicionContratoCliente = false;
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cargarInformacionCliente(idCliente: number): void{
    this.clienteService.obtenerInformacionClienteId(idCliente)
    .subscribe({
      next: (response) => {
        if(response != null){
          this.nombreCliente = response.cliePrimerNom;
          this.apellidoCliente = response.clieApellidos;
          this.nitCliente = response.clieNit;
          this.idEmpresaCliente = response.clieEmpresaId;
        }
      }
    });
  }

}
