import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GestionSucursalClienteComponent } from './gestion-sucursal-cliente.component';

describe('GestionSucursalClienteComponent', () => {
  let component: GestionSucursalClienteComponent;
  let fixture: ComponentFixture<GestionSucursalClienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GestionSucursalClienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GestionSucursalClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
