import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarSucursalClienteComponent } from './editar-sucursal-cliente.component';

describe('EditarSucursalClienteComponent', () => {
  let component: EditarSucursalClienteComponent;
  let fixture: ComponentFixture<EditarSucursalClienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarSucursalClienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarSucursalClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
