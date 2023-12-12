import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TipoListEnum } from 'src/app/models/enums-aplicacion.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { EmpresaService } from 'src/app/services/empresa-service/empresa.service';
import swal from 'sweetalert2';

@Component({
  selector: 'app-crear-empresa-page',
  templateUrl: './crear-empresa-page.component.html',
  styleUrls: ['./crear-empresa-page.component.scss']
})
export class CrearEmpresaPageComponent implements OnInit {

  empresaFormGroup: FormGroup;
  fb = new FormBuilder();

  listTipoId: IListCombo[] = [];
  listRespFiscal: IListCombo[] = [];
  listRespTributaria: IListCombo[] = [];
  listTipoCliente: IListCombo[] = [];
  ListRegEmpresa: IListCombo[] = [];
  listClasJuridica: IListCombo[] = [];

  empresaCollapsed: boolean = false;

  constructor(
    private empresaService: EmpresaService,
    private cargueCombosService: CargueCombosService
  ) { }

  ngOnInit(): void {
    this.initForm();
    this.cargarComboListas();
  }

  cargarComboListas(): void {

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_ID)
    .subscribe({
      next: (response) => {
        this.listTipoId = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.RESP_FISCAL)
    .subscribe({
      next: (response) => {
        this.listRespFiscal = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.RESP_TRIBUTARIA)
    .subscribe({
      next: (response) => {
        this.listRespTributaria = response;
      }
    });

    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.TIPO_CLIENTE)
    .subscribe({
      next: (response) => {
        this.listTipoCliente = response;
      }
    });

    this.cargueCombosService.obtenerListaRegimen()
    .subscribe({
      next: (response) => {
        this.ListRegEmpresa = response;
      }
    });

    this.cargueCombosService.obtenerListaClasesJuridicas()
    .subscribe({
      next: (response) => {
        this.listClasJuridica = response;
      }
    });

  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      emprNombre: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprNit: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDv: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDepto: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprCiudad: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDireccion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprTelefono: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprMail: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprPagWeb: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRepLegal: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprIdRepLegal: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprCiuu: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprContacto: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprFormatoImpr: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprHabilitacion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLocalidad: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprObservaciones: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprPorcReteIca: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRecepcion: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRegimenId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRespFiscalId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprRespTributId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprTipoClienteId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprTipoIdId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLeyEnFactura: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLeyEnNotaCredito: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprLeyEnNotaDebito: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprFactContador: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprClasJuridicaId: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprCelular: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      emprDiasPago: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ]
    };

    this.empresaFormGroup = this.fb.group(formControls);
  }

  submitForm(): void {

    if (this.empresaFormGroup.invalid) {
      this.empresaFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IEmpresa = this.empresaFormGroup.getRawValue();
    dataBody.id = 0;
    dataBody.estado = 1;

    this.empresaService.crearEmpresa(dataBody).subscribe({
      next: (response) => {
        this.empresaFormGroup.reset();
        swal.fire(``, 'La empresa fue creada de forma exitosa.', 'success');
      }
    });

  }

}
