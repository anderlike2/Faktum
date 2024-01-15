import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { map } from 'rxjs/operators';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ClienteService } from 'src/app/services/cliente-service/cliente.service';
import { ContratoClienteService } from 'src/app/services/contrato-cliente-service/contrato-cliente.service';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-crear-contrato-cliente',
  templateUrl: './crear-contrato-cliente.component.html',
  styleUrls: ['./crear-contrato-cliente.component.scss']
})
export class CrearContratoClienteComponent implements OnInit {

  @Input() clienteID: number;

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
    private generalService: GeneralService,
    private modalRef: NgbActiveModal,
    private clienteService: ClienteService
  ) { }

  ngOnInit(): void {
    this.init();
    this.cargarInformacionCliente(this.clienteID);
  }

  init(): void {
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

    dataBody.id = 0;
    dataBody.estado = 1;

    dataBody.cosaClieId = this.clienteID;
    dataBody.cosaEmpresaId = this.idEmpresaCliente;

    this.contratoClienteService.crearContratoCliente(dataBody).subscribe({
      next: (response: any) => {
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
