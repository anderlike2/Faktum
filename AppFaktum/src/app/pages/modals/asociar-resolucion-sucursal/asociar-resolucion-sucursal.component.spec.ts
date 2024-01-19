import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AsociarResolucionSucursalComponent } from './asociar-resolucion-sucursal.component';

describe('AsociarResolucionSucursalComponent', () => {
  let component: AsociarResolucionSucursalComponent;
  let fixture: ComponentFixture<AsociarResolucionSucursalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AsociarResolucionSucursalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AsociarResolucionSucursalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
