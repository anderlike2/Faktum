import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IResolucion } from 'src/app/models/resolucion.model';
import { ResolucionService } from 'src/app/services/resolucion-service/resolucion.service';
import { ResolucionSucursalService } from 'src/app/services/resolucion-sucursal-service/resolucion-sucursal.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { IResolucionSucursal } from 'src/app/models/resolucion-sucursal.model';
import { GeneralesEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-asociar-resolucion-sucursal',
  templateUrl: './asociar-resolucion-sucursal.component.html',
  styleUrls: ['./asociar-resolucion-sucursal.component.scss']
})
export class AsociarResolucionSucursalComponent implements OnInit {

  @Input() sucursalID: number;

  resolucionSucursalFormGroup: FormGroup;
  fb = new FormBuilder();
  
  dataEmpresa: IEmpresa;
  listResoluciones: IResolucion[] = [];

  constructor(private storageService: StorageService, private resolucionService: ResolucionService, private modalRef: NgbActiveModal,
    private generalService: GeneralService, private resolucionSucursalService: ResolucionSucursalService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.dataEmpresa = this.storageService.getEmpresaActivaStorage();
    this.cargarListasCombobox();
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

  guardarResolucionSucursal(): void {
    if (this.resolucionSucursalFormGroup.invalid) {
      this.resolucionSucursalFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: IResolucionSucursal = this.resolucionSucursalFormGroup.getRawValue();

    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.resuSucursalId = this.sucursalID;

    this.resolucionSucursalService.crearResolucionSucursal(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
        }else{
           this.cerrarModal(true);
           this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
        }
      }
    });
  }

  cerrarModal(info?: any) {
    this.modalRef.close(info);
  }

}
