import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalleListaPreciosProductosComponent } from './detalle-lista-precios-productos.component';

describe('DetalleListaPreciosProductosComponent', () => {
  let component: DetalleListaPreciosProductosComponent;
  let fixture: ComponentFixture<DetalleListaPreciosProductosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DetalleListaPreciosProductosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DetalleListaPreciosProductosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
