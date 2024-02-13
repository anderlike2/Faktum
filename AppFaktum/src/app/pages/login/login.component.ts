import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { LoginService } from '../../services/login-service/login.service';
import { ILogin, ILoginResponse } from 'src/app/models/login.model';
import { AuthService } from 'src/app/services/auth-service/auth.service';
import { Router } from '@angular/router';
import swal from 'sweetalert2';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { IUsuario } from 'src/app/models/usuario.model';
import { GeneralService } from 'src/app/services/general-service/general.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginFormGroup: FormGroup;
  fb = new FormBuilder();

  constructor(
    private loginService: LoginService,
    private authService: AuthService,
    private storageService: StorageService,
    private router: Router,
    private generalService: GeneralService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      usuario: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ],
      clave: [
        { value: '', disabled: false },
        [
          Validators.required
        ]
      ]
    }

    this.loginFormGroup = this.fb.group(formControls);

  }

  get usuarioErrorMensaje(): string {
    const form: AbstractControl = this.loginFormGroup.get('usuario') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  get claveErrorMensaje(): string {
    const form: AbstractControl = this.loginFormGroup.get('clave') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  onSubmit(): void {
    if (this.loginFormGroup.invalid) {
      this.loginFormGroup.markAllAsTouched();
      return;
    }

    const formValue = this.loginFormGroup.getRawValue();
    //const encrypt = this.generalService.encrypt(formValue.clave);
    //const decrypt = this.generalService.decrypt(encrypt);

    const formBody: ILogin = {
      usuario: formValue.usuario,
      clave: formValue.clave
    }

    this.loginService.login(formBody).subscribe({
      next: (response) => {

        if (!response?.success) {
         return swal.fire({
            text: response?.message,
            icon: 'warning',
            confirmButtonText: 'Aceptar'
          });
        }

        const info: ILoginResponse = response?.data;

        const usuario: IUsuario = info;

        this.storageService.setEmpresaStorage(info.usuEmpresas);
        this.storageService.setUserRolesStorage(info.usuaRoles);
        this.storageService.setUserStorage( usuario );

        this.router.navigateByUrl('/');
      }
    });

  }

}
