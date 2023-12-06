import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { TipoListEnum } from 'src/app/models/detalle-empresa.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IListCombo } from 'src/app/models/general.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';

@Component({
  selector: 'app-detalle-cliente',
  templateUrl: './detalle-cliente.component.html',
  styleUrls: ['./detalle-cliente.component.scss']
})
export class DetalleClienteComponent implements OnInit {

  clienteFormGroup: FormGroup;
  fb = new FormBuilder();

  listPaises: IListCombo[] = [];
  listDeptos: IListCombo[] = [];
  listEmpresas: IEmpresa[] = [];

  constructor(private cargueCombosService: CargueCombosService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarComboListas();
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
      empresaId: [ { value: '', disabled: false }, [  ] ]
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
  }
}
