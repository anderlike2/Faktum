import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListaPrecio } from 'src/app/models/lista-precio.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ListaPrecioService } from 'src/app/services/lista-precio-service/lista-precio.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';

@Component({
  selector: 'app-editar-lista-precio',
  templateUrl: './editar-lista-precio.component.html',
  styleUrls: ['./editar-lista-precio.component.scss']
})
export class EditarListaPrecioComponent implements OnInit {

  listaPrecioCollapsed: boolean = false;
  edicionListaPrecio: boolean = false;

  listaPrecioData: IListaPrecio;

  listaFormatoFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private listaPrecioService: ListaPrecioService,
    private sharedService: SharedService,
    private generalService: GeneralService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.listaPrecioDataListener$.subscribe(this.obtenerListaPrecio.bind(this));
    this.initForm();
  }

  obtenerListaPrecio(data: IListaPrecio): void {
    this.listaPrecioService.obtenerListaPrecioPorId(data?.id)
    .subscribe({
      next: (response) => {
        if(response?.success) {
          this.listaPrecioData = response.data;
          this.cargarDataForm(response.data);
        }
      }
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      liprNombre: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprDescripcion: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprDescuento: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprValor: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprEstadoOperacion: [ { value: '', disabled: false }, [ Validators.required ] ],
      liprProductoId: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.listaFormatoFormGroup = this.fb.group(formControls);
  }

  cargarDataForm(data: IListaPrecio): void {
    this.listaFormatoFormGroup.disable();
    this.edicionListaPrecio = false;
    this.listaFormatoFormGroup.patchValue(
      data
    );
  }

  editarForm(): void {
    this.listaFormatoFormGroup.enable();
    this.edicionListaPrecio = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.listaPrecioData);
  }

  guardarFormatoImpresion(): void {
    if (this.listaFormatoFormGroup.invalid) {
      this.listaFormatoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IListaPrecio = this.listaFormatoFormGroup.getRawValue();

    dataBody.id = this.listaPrecioData.id;
    dataBody.estado = this.listaPrecioData.estado;
    dataBody.liprSucursalClienteId = this.listaPrecioData.liprSucursalClienteId;
    dataBody.fechaCreacion = this.listaPrecioData.fechaCreacion;
    dataBody.fechaModificacion = this.listaPrecioData.fechaModificacion;

    this.listaPrecioService.actualizarListaPrecio(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.listaFormatoFormGroup.disable();
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
