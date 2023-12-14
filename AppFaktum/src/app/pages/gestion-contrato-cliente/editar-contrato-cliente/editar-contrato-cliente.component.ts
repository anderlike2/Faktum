import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { map } from 'rxjs/operators';
import { IContratoCliente } from 'src/app/models/contrato-cliente.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
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

  constructor(
    private contratoClienteService: ContratoClienteService,
    private cargueCombosService: CargueCombosService,
    private sharedService: SharedService,
    private generalService: GeneralService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {

    this.sharedService.contratoClienteDataListener$.subscribe(this.obtenerContratoCliente.bind(this));

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

    dataBody.id = this.contratoClienteData.id;
    dataBody.estado = this.contratoClienteData.estado;

    // toca hablar de estos dos
    dataBody.cosaClieIdId = this.contratoClienteData.id;
    dataBody.fechaCreacion = this.contratoClienteData.fechaCreacion;
    dataBody.fechaModificacion = this.contratoClienteData.fechaModificacion;

    this.contratoClienteService.actualizarContratoCliente(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.contratoClienteFormGroup.disable();
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
