import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalleSucursalClienteComponent } from './detalle-sucursal-cliente.component';

describe('DetalleSucursalClienteComponent', () => {
  let component: DetalleSucursalClienteComponent;
  let fixture: ComponentFixture<DetalleSucursalClienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DetalleSucursalClienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DetalleSucursalClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
