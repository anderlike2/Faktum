import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearSucursalClienteComponent } from './crear-sucursal-cliente.component';

describe('CrearSucursalClienteComponent', () => {
  let component: CrearSucursalClienteComponent;
  let fixture: ComponentFixture<CrearSucursalClienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearSucursalClienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearSucursalClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
