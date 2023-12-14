import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearContratoClienteComponent } from './crear-contrato-cliente.component';

describe('CrearContratoClienteComponent', () => {
  let component: CrearContratoClienteComponent;
  let fixture: ComponentFixture<CrearContratoClienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearContratoClienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearContratoClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
