import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-crear-sucursal',
  templateUrl: './crear-sucursal.component.html',
  styleUrls: ['./crear-sucursal.component.scss']
})
export class CrearSucursalComponent implements OnInit {

  sucursalFormGroup: FormGroup;
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

    };

    this.sucursalFormGroup = this.fb.group(formControls);
  }

}
