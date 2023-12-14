import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { TipoListEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursal } from 'src/app/models/sucursal.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { DetalleEmpresaService } from 'src/app/services/detalle-empresa-service/detalle-empresa.service';
import swal from 'sweetalert2';

@Component({
  selector: 'app-crear-sucursal',
  templateUrl: './crear-sucursal.component.html',
  styleUrls: ['./crear-sucursal.component.scss']
})
export class CrearSucursalComponent implements OnInit {

  @Input() empresaID: number;

  sucursalFormGroup: FormGroup;
  fb = new FormBuilder();
  listCentroCostos: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listCiudades: IListCombo[] = [];

  constructor(
    private detalleEmpresaService: DetalleEmpresaService,
    private cargueCombosService: CargueCombosService,
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

    this.cargueCombosService.obtenerListaCentrosCostoEmpresa(this.empresaID)
    .subscribe({
      next: (response) => {
        this.listCentroCostos = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.DEPARTAMENTO)
    .subscribe({
      next: (response) => {
        this.listDeptos = response;
      }
    });

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

    dataBody.id = 0;
    dataBody.estado = 1;

    // toca hablar de estos dos
    dataBody.sucuEmpresaId = this.empresaID;
    dataBody.sucuFormatoImpresionId = 1;
    dataBody.sucuPrincipal = 0;

    this.detalleEmpresaService.crearSucursal(dataBody).subscribe({
      next: (response: any) => {
        this.modalRef.close();
        swal.fire(``, response.message, 'success');
      }
    });
  }

  cerrarModal() {
    this.modalRef.close();
  }

  cargarCiudadesDepto(idDepto: number): void{
    this.cargueCombosService.obtenerListaCiudadesDepto(idDepto)
    .subscribe({
      next: (response) => {
        this.listCiudades = response;
      }})
  }

}
