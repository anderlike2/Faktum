import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
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

  initForm(): void {
    const formControls: { [key: string]: any } = {
      usuaUsuario: [ { value: '', disabled: false }, [  ] ],
      usuaPassword: [ { value: '', disabled: false }, [  ] ],
      usuaPasswordConfirm: [ { value: '', disabled: false }, [  ] ],
      usuaEmpresaId: [ { value: '', disabled: false }, [  ] ],
      usuaRolId: [ { value: '', disabled: false }, [  ] ]
    }

    this.usuarioFormGroup = this.fb.group(formControls);
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

  guardarUsuario(): void {
    if (this.usuarioFormGroup.invalid) {
      this.usuarioFormGroup.markAllAsTouched();
      return;
    }

    const dataBody: ICrearUsuario = this.usuarioFormGroup.getRawValue();
    dataBody.id = 0;
    dataBody.estado = 1;

    this.usuarioService.crearUsuario(dataBody).subscribe({
      next: (response: any) => {
        if (!response?.success) {
         this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.WARNINNG, GeneralesEnum.BTN_ACEPTAR)
         }else{
          this.generalService.mostrarMensajeAlerta(response?.message, TiposMensajeEnum.SUCCESS, GeneralesEnum.BTN_ACEPTAR)
         }
      }
    });
  }

}
