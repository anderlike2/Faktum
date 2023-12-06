import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import swal from 'sweetalert2';

@Component({
  selector: 'app-detalle-sucursal',
  templateUrl: './detalle-sucursal.component.html',
  styleUrls: ['./detalle-sucursal.component.scss']
})
export class DetalleSucursalComponent implements OnInit {

  sucursalCollapsed: boolean = false;
  edicionSucursal: boolean = false;

  sucursalData: ISucursal;

  sucursalFormGroup: FormGroup;
  fb = new FormBuilder();

  listCentroCostos: IListCombo[] = [];

  constructor(
    private detalleEmpresaService: DetalleEmpresaService,
    private cargueCombosService: CargueCombosService,
    private sharedService: SharedService
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
    this.cargarDataForm();
  }

  cargarListaCombox(): void {

    this.cargueCombosService.obtenerListaCentrosCostoEmpresa(this.sucursalData.sucuEmpresaId)
    .subscribe({
      next: (response) => {
        this.listCentroCostos = response;
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
        this.sucursalFormGroup.disable();
        swal.fire(``, response.message, 'success');
      }
    });
  }

}
