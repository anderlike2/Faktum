import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import swal from 'sweetalert2';

@Component({
  selector: 'app-editar-sucursal',
  templateUrl: './editar-sucursal.component.html',
  styleUrls: ['./editar-sucursal.component.scss']
})
export class EditarSucursalComponent implements OnInit {

  sucursalCollapsed: boolean = false;
  edicionSucursal: boolean = false;

  sucursalData: ISucursal;

  sucursalFormGroup: FormGroup;
  fb = new FormBuilder();

  listCentroCostos: IListCombo[] = [];
  listFormatosImpresion: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listCiudades: IListCombo[] = [];

  constructor(
    private detalleEmpresaService: DetalleEmpresaService,
    private cargueCombosService: CargueCombosService,
    private sharedService: SharedService,
    private generalService: GeneralService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {

    this.sharedService.sucursalEmpresaDataListener$.subscribe({
      next: (data) => {
        this.sucursalData = data;
      }
    });

    this.initForm();
    this.cargarListaCombox();

    if(this.sucursalData.sucuDepto != undefined && this.sucursalData.sucuDepto != null && this.sucursalData.sucuDepto != "")
            this.cargarCiudadesDepto(Number(this.sucursalData.sucuDepto));

    this.cargarDataForm();
  }

  cargarListaCombox(): void {

    this.cargueCombosService.obtenerListaCentrosCostoEmpresa(this.sucursalData.sucuEmpresaId)
    .subscribe({
      next: (response) => {
        this.listCentroCostos = response;
      }
    });
    this.cargueCombosService.obtenerListaFormatosImpresionEmpresa(this.sucursalData.sucuEmpresaId)
    .subscribe({
      next: (response) => {
        this.listFormatosImpresion = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.DEPARTAMENTO)
    .subscribe({
      next: (response) => {
        this.listDeptos = response;
      }
    });
  }

  cargarDataForm(): void {
    this.sucursalFormGroup.disable();
    this.edicionSucursal = false;
    this.sucursalFormGroup.patchValue(
      this.sucursalData
    );
  }

  editarForm(): void {
    this.sucursalFormGroup.enable();
    this.edicionSucursal = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      sucuNombre: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      sucuDepto: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCelular: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCiudad: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCodigo: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuContacto: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuDireccion: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuEstadoOperacion: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuHabilitacion: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuLeyendaFactura: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuLeyendaNotaCredito: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuLeyendaNotaDebito: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuListPrecio: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuMail: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuObservaciones: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuReteIca: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuTelefono: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuCentroCostosId: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ],
      sucuFormatoImpresionId: [ { value: '', disabled: false }, [
        Validators.required
      ]
    ]
    };

    this.sucursalFormGroup = this.fb.group(formControls);
  }


  guardarSucursal(): void {
    if (this.sucursalFormGroup.invalid) {
      this.sucursalFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ISucursal = this.sucursalFormGroup.getRawValue();

    dataBody.id = this.sucursalData.id;
    dataBody.estado = this.sucursalData.estado;

    // toca hablar de estos dos
    dataBody.sucuEmpresaId = this.sucursalData.sucuEmpresaId;
    dataBody.sucuFormatoImpresionId = this.sucursalData.sucuFormatoImpresionId;
    dataBody.sucuPrincipal = this.sucursalData.sucuPrincipal;
    dataBody.fechaCreacion = this.sucursalData.fechaCreacion;
    dataBody.fechaModificacion = this.sucursalData.fechaModificacion;

    this.detalleEmpresaService.actualizarSucursal(dataBody).subscribe({
      next: (response: any) => {        
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.sucursalFormGroup.disable();
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
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

}
