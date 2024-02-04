import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { map } from 'rxjs/operators';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IListCombo } from 'src/app/models/general.model';
import { IListaPrecio } from 'src/app/models/lista-precio.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ListaPrecioService } from 'src/app/services/lista-precio-service/lista-precio.service';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-editar-lista-precio',
  templateUrl: './editar-lista-precio.component.html',
  styleUrls: ['./editar-lista-precio.component.scss']
})
export class EditarListaPrecioComponent implements OnInit {

  listaPrecioCollapsed: boolean = false;
  edicionListaPrecio: boolean = false;

  listaPrecioData: IListaPrecio;
  dataEmpresa: IEmpresa;

  listaFormatoFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private listaPrecioService: ListaPrecioService,
    private sharedService: SharedService,
    private generalService: GeneralService,
    private storageService: StorageService,
    private productoService: ProductoService) { }

  ngOnInit(): void {
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.init();
  }

  init(): void {
    this.sharedService.editarGeneralDataListener$.subscribe(this.obtenerListaPrecio.bind(this));
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
      liprEstadoOperacion: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.listaFormatoFormGroup = this.fb.group(formControls);
  }

  get liprNombreErrorMensaje(): string {
    const form: AbstractControl = this.listaFormatoFormGroup.get('liprNombre') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get liprDescripcionErrorMensaje(): string {
    const form: AbstractControl = this.listaFormatoFormGroup.get('liprDescripcion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get liprEstadoOperacionErrorMensaje(): string {
    const form: AbstractControl = this.listaFormatoFormGroup.get('liprEstadoOperacion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
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

  guardarListaPrecio(): void {
    if (this.listaFormatoFormGroup.invalid) {
      this.listaFormatoFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IListaPrecio = this.listaFormatoFormGroup.getRawValue();

    dataBody.id = this.listaPrecioData.id;
    dataBody.estado = this.listaPrecioData.estado;
    dataBody.liprEmpresaId = this.listaPrecioData.liprEmpresaId;
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
