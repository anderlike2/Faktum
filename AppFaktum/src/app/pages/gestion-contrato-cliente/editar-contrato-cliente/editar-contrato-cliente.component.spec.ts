import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarContratoClienteComponent } from './editar-contrato-cliente.component';

describe('EditarContratoClienteComponent', () => {
  let component: EditarContratoClienteComponent;
  let fixture: ComponentFixture<EditarContratoClienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarContratoClienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarContratoClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
