import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { ISucursalCliente } from 'src/app/models/sucursal-cliente.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { SucursalClienteService } from 'src/app/services/sucursal-cliente-service/sucursal-cliente.service';

@Component({
  selector: 'app-editar-sucursal-cliente',
  templateUrl: './editar-sucursal-cliente.component.html',
  styleUrls: ['./editar-sucursal-cliente.component.scss']
})
export class EditarSucursalClienteComponent implements OnInit {

  sucursalClienteFormGroup: FormGroup;
  fb = new FormBuilder();

  edicionSucursalCliente: boolean = false;
  informacionSucursalCliente: ISucursalCliente;
  listDeptos: IListCombo[] = [];
  listCiudades: IListCombo[] = [];

  sucursalClienteCollapsed: boolean = true;
  listaPreciosSucursalClienteCollapsed: boolean = true;

  constructor(private cargueCombosService: CargueCombosService, private sharedService: SharedService,
    private sucursalClienteService: SucursalClienteService, private generalService: GeneralService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.sucursalClienteDataListener$.subscribe({
      next: (data) => {
        this.informacionSucursalCliente = data;
      }
    });

    this.initForm();
    this.cargarComboListas();
    this.cargarInformacionSucursalCliente(this.informacionSucursalCliente.id);
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

  cargarInformacionSucursalCliente(idSucursalCliente: number): void{
    this.sucursalClienteService.obtenerInformacionSucursalClienteId(idSucursalCliente)
    .subscribe({
      next: (response) => {
        if(response != null){
          if(response.suclDepto != undefined && response.suclDepto != null && response.suclDepto != "")
            this.cargarCiudadesDepto(Number(response.suclDepto));

            this.sucursalClienteFormGroup.patchValue({
              suclNombre: response.suclNombre,
              suclDepto: response.suclDepto,
              suclCiudad: response.suclCiudad,
              suclCodigo: response.suclCodigo,
              suclContacto: response.suclContacto,
              suclCorreo: response.suclCorreo,
              suclDiasPago: response.suclDiasPago,
              suclListaPrecio: response.suclListaPrecio,
              suclTelefono: response.suclTelefono
            });
        }
      }
    });
    this.sucursalClienteFormGroup.disable();
    this.edicionSucursalCliente = false;
  }

  editarForm(): void {
    this.sucursalClienteFormGroup.enable();
    this.edicionSucursalCliente = true;
  }

  cancelarEdicion(): void {
    this.cargarInformacionSucursalCliente(this.informacionSucursalCliente.id);
  }

  actualizarSucursalCliente(): void{
    if(this.sucursalClienteFormGroup.invalid) {
      this.sucursalClienteFormGroup.markAllAsTouched();
      return;
    }

    const formData = this.sucursalClienteFormGroup.getRawValue();
    formData.id = this.informacionSucursalCliente.id;
    formData.estado = this.informacionSucursalCliente.estado;
    formData.fechaCreacion = this.informacionSucursalCliente.fechaCreacion;
    formData.fechaModificacion = this.informacionSucursalCliente.fechaModificacion;
    formData.suclClienteId = this.informacionSucursalCliente.suclClienteId;

    this.sucursalClienteService.actualizarSucursalCliente(formData)
    .subscribe({
      next: (response) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
           this.sucursalClienteFormGroup.disable();
           this.cargarInformacionSucursalCliente(this.informacionSucursalCliente.id);
        }
      }
    });
  }

}
