import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IEmpresa } from 'src/app/models/empresa.model';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IResolucionSucursal } from 'src/app/models/resolucion-sucursal.model';
import { IResolucion } from 'src/app/models/resolucion.model';
import { GeneralService } from 'src/app/services/general-service/general.service';
import { ResolucionService } from 'src/app/services/resolucion-service/resolucion.service';
import { ResolucionSucursalService } from 'src/app/services/resolucion-sucursal-service/resolucion-sucursal.service';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { SucursalService } from 'src/app/services/sucursal-service/sucursal.service';

@Component({
  selector: 'app-editar-resolucion-sucursal',
  templateUrl: './editar-resolucion-sucursal.component.html',
  styleUrls: ['./editar-resolucion-sucursal.component.scss']
})
export class EditarResolucionSucursalComponent implements OnInit {

  resolucionSucursalCollapsed: boolean = false;
  edicionResolucionSucursal: boolean = false;

  resolucionSucursalData: IResolucionSucursal;

  resolucionSucursalFormGroup: FormGroup;
  fb = new FormBuilder();

  dataEmpresa: IEmpresa;
  nombreSucursal: string;
  codigoSucursal: string;

  listResoluciones: IResolucion[] = [];

  constructor(private sharedService: SharedService, private resolucionSucursalService: ResolucionSucursalService,
    private resolucionService: ResolucionService, private storageService: StorageService, private generalService: GeneralService,
    private sucursalService: SucursalService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.sharedService.resolucionSucursalListener$.subscribe(this.obtenerResolucionSucursal.bind(this));
    this.initForm();
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarListasCombobox();
  }

  obtenerResolucionSucursal(data: IResolucion): void {
    this.resolucionSucursalService.obtenerResolucionSucursalPorId(data.id)
    .subscribe({
      next: (response) => {
        if(response != null){
          this.sucursalService.obtenerSucursalPorId(response.data.resuSucursalId)
          .subscribe({
            next: (response1) => {
              if(response1 != null){
                this.nombreSucursal = response1.data.sucuNombre;
                this.codigoSucursal = response1.data.sucuCodigo;
                this.cargarDataForm(response.data);
                this.resolucionSucursalData = response.data;
              }
            }
          });
        }
      }
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      resuResolucionId: [ { value: '', disabled: false }, [ Validators.required ] ]
    };

    this.resolucionSucursalFormGroup = this.fb.group(formControls);
  }

  get resuResolucionIdErrorMensaje(): string {
    const form: AbstractControl = this.resolucionSucursalFormGroup.get('resuResolucionId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio'
      : '';
  }

  cargarListasCombobox(): void {
    this.resolucionService.obtenerResolucionesPorEmpresaId(this.dataEmpresa.id).subscribe({
      next: (response) => {
        this.listResoluciones = response;
      }
    });;
  }

  editarForm(): void {
    this.resolucionSucursalFormGroup.enable();
    this.edicionResolucionSucursal = true;
  }

  cancelarEdicion(): void {
    this.cargarDataForm(this.resolucionSucursalData);
  }

  cargarDataForm(data: IResolucionSucursal): void {
    this.resolucionSucursalFormGroup.disable();
    this.edicionResolucionSucursal = false;
    this.resolucionSucursalFormGroup.patchValue(
      data
    );
  }

  guardarResolucionSucursal(): void {
    if (this.resolucionSucursalFormGroup.invalid) {
      this.resolucionSucursalFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IResolucionSucursal = this.resolucionSucursalFormGroup.getRawValue();

    dataBody.id = this.resolucionSucursalData.id;
    dataBody.estado = this.resolucionSucursalData.estado;

    dataBody.resuSucursalId = this.resolucionSucursalData.resuSucursalId;
    dataBody.fechaCreacion = this.resolucionSucursalData.fechaCreacion;
    dataBody.fechaModificacion = this.resolucionSucursalData.fechaModificacion;

    this.resolucionSucursalService.actualizarResolucionSucursal(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
          this.resolucionSucursalFormGroup.disable();
          this.edicionResolucionSucursal = false;
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

}
