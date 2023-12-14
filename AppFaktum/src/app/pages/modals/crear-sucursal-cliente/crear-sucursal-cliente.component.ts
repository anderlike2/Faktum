import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursalCliente } from 'src/app/models/sucursal-cliente.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SucursalClienteService } from 'src/app/services/sucursal-cliente-service/sucursal-cliente.service';

@Component({
  selector: 'app-crear-sucursal-cliente',
  templateUrl: './crear-sucursal-cliente.component.html',
  styleUrls: ['./crear-sucursal-cliente.component.scss']
})
export class CrearSucursalClienteComponent implements OnInit {

  @Input() clienteID: number;

  sucursalClienteFormGroup: FormGroup;
  fb = new FormBuilder();

  listDeptos: IListCombo[] = [];
  listCiudades: IListCombo[] = [];

  constructor(private cargueCombosService: CargueCombosService,
    private sucursalClienteService: SucursalClienteService, private generalService: GeneralService,
    private modalRef: NgbActiveModal) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarComboListas();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      suclDepto: [ { value: '', disabled: false }, [  ] ],
      suclCiudad: [ { value: '', disabled: false }, [  ] ],
      suclNombre: [ { value: '', disabled: false }, [  ] ],
      suclCodigo: [ { value: '', disabled: false }, [  ] ],
      suclContacto: [ { value: '', disabled: false }, [  ] ],
      suclCorreo: [ { value: '', disabled: false }, [  ] ],
      suclDiasPago: [ { value: '', disabled: false }, [  ] ],
      suclListaPrecio: [ { value: '', disabled: false }, [  ] ],
      suclTelefono: [ { value: '', disabled: false }, [  ] ],
      suclClienteId: [ { value: '', disabled: false }, [  ] ],
    }
    this.sucursalClienteFormGroup = this.fb.group(formControls);
  }

  cargarComboListas(): void {
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.DEPARTAMENTO)
    .subscribe({
      next: (response) => {
        this.listDeptos = response;
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

  guardarSucursalCliente(): void {
    if (this.sucursalClienteFormGroup.invalid) {
      this.sucursalClienteFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ISucursalCliente = this.sucursalClienteFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.suclClienteId = this.clienteID;

    this.sucursalClienteService.crearSucursalCliente(dataBody).subscribe({
      next: (response: any) => {        
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.modalRef.close();
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cerrarModal() {
    this.modalRef.close();
  }

}
