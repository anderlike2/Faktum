import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-confirmacion',
  templateUrl: './confirmacion.component.html',
  styleUrls: ['./confirmacion.component.scss']
})
export class ConfirmacionComponent implements OnInit {

  constructor(private modalRef: NgbActiveModal) { }

  ngOnInit(): void {
  }

  guardar() {
    this.cerrarModal(true);
  }

  cerrarModal(info?: any) {
    this.modalRef.close(info);
  }

}
