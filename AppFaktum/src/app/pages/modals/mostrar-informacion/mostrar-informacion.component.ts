import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-mostrar-informacion',
  templateUrl: './mostrar-informacion.component.html',
  styleUrls: ['./mostrar-informacion.component.scss']
})
export class MostrarInformacionComponent implements OnInit {

  @Input() informacionMostrar: string;
  informacionMostrarModal: string;

  constructor(private modalRef: NgbActiveModal) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.initForm();
  }

  initForm(): void {
    this.informacionMostrarModal = this.informacionMostrar;
  }

  cerrarModal() {
    this.modalRef.close();
  }

}
