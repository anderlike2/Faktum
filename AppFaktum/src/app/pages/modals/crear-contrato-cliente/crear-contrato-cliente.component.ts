import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { map } from 'rxjs/operators';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
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

  constructor(
    private contratoClienteService: ContratoClienteService,
    private cargueCombosService: CargueCombosService,
    private generalService: GeneralService,
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
    this.init();
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
      cosaNitCliente: [ { value: '', disabled: false }, [
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
      cosaEmpresaId: [ { value: '', disabled: false }, [
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


  guardarContratoCliente(): void {
    if (this.contratoClienteFormGroup.invalid) {
      this.contratoClienteFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IContratoCliente = this.contratoClienteFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;

    dataBody.cosaClieIdId = this.clienteID;

    this.contratoClienteService.crearContratoCliente(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
           this.cerrarModal();
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cerrarModal() {
    this.modalRef.close();
  }

}