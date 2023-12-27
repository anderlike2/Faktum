import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearCabeceraFacturaComponent } from './crear-cabecera-factura.component';

describe('CrearCabeceraFacturaComponent', () => {
  let component: CrearCabeceraFacturaComponent;
  let fixture: ComponentFixture<CrearCabeceraFacturaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearCabeceraFacturaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearCabeceraFacturaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
