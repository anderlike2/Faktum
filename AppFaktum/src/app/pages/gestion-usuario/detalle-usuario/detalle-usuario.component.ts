import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-detalle-usuario',
  templateUrl: './detalle-usuario.component.html',
  styleUrls: ['./detalle-usuario.component.scss']
})
export class DetalleUsuarioComponent implements OnInit {

  usuarioFormGroup: FormGroup;
  fb = new FormBuilder();
  
  constructor() { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      nombreUsuario: [ { value: '', disabled: false }, [  ] ],
      passwordUsuario: [ { value: '', disabled: false }, [  ] ],
      confirmarPasswordUsuario: [ { value: '', disabled: false }, [  ] ],
    }

    this.usuarioFormGroup = this.fb.group(formControls);
  }
}
