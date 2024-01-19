import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarResolucionSucursalComponent } from './editar-resolucion-sucursal.component';

describe('EditarResolucionSucursalComponent', () => {
  let component: EditarResolucionSucursalComponent;
  let fixture: ComponentFixture<EditarResolucionSucursalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarResolucionSucursalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarResolucionSucursalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
