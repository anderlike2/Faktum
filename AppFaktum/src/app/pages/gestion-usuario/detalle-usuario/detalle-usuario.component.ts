import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GeneralesEnum, TipoListEnum, TiposMensajeEnum } from 'src/app/models/enums-aplicacion.model';
import { IEmpresa } from 'src/app/models/empresa.model';
import { IListCombo } from 'src/app/models/general.model';
import { ICrearUsuario } from 'src/app/models/crear-usuario.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { EmpresaService } from 'src/app/services/empresa-service/empresa.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { UsuarioService } from 'src/app/services/usuario-service/usuario.service';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-detalle-usuario',
  templateUrl: './detalle-usuario.component.html',
  styleUrls: ['./detalle-usuario.component.scss']
})
export class DetalleUsuarioComponent implements OnInit {

  usuarioFormGroup: FormGroup;
  fb = new FormBuilder();

  listEmpresas: IEmpresa[] = [];
  listRoles: IListCombo[] = [];

  constructor(private storageService: StorageService, private empresaService: EmpresaService,
    private cargueCombosService: CargueCombosService, private usuarioService: UsuarioService,
    private generalService: GeneralService) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
    this.cargarCombobox();
  }

  cargarCombobox() {
    const usuario = this.storageService.getUsuarioStorage();
    this.empresaService.consultarEmpresasUsusario(usuario.id)
    .subscribe({
      next: (response) => {
        this.listEmpresas = response;
      }
    });
    this.cargueCombosService.obtenerListaTablaMaestro(TipoListEnum.ROL)
    .subscribe({
      next: (response) => {
        this.listRoles = response;
      }
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      usuaUsuario: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      usuaPassword: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      usuaPasswordConfirm: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      usuaEmpresaId: [ { value: '', disabled: false }, [
        Validators.required
       ] ],
      usuaRolId: [ { value: '', disabled: false }, [
        Validators.required
       ] ]
    }

    this.usuarioFormGroup = this.fb.group(formControls);
  }

  get usuaUsuarioErrorMensaje(): string {
    const form: AbstractControl = this.usuarioFormGroup.get('usuaUsuario') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get usuaPasswordErrorMensaje(): string {
    const form: AbstractControl = this.usuarioFormGroup.get('usuaPassword') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get usuaPasswordConfirmErrorMensaje(): string {
    const form: AbstractControl = this.usuarioFormGroup.get('usuaPasswordConfirm') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get usuaEmpresaIdErrorMensaje(): string {
    const form: AbstractControl = this.usuarioFormGroup.get('usuaEmpresaId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get usuaRolIdErrorMensaje(): string {
    const form: AbstractControl = this.usuarioFormGroup.get('usuaRolId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }


  guardarUsuario(): void {
    if (this.usuarioFormGroup.invalid) {
      this.usuarioFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ICrearUsuario = this.usuarioFormGroup.getRawValue();
    dataBody.id = 0;
    dataBody.estado = 1;
    dataBody.usuaIntentos = 0;

    this.usuarioService.crearUsuario(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
         this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR);
         }else{
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR);
          this.limpiarFormulario();
         }
      }
    });
  }

  limpiarFormulario(): void{
    this.usuarioFormGroup.reset();
  }

}
