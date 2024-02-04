import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearListaPrecioProductoComponent } from './crear-lista-precio-producto.component';

describe('CrearListaPrecioProductoComponent', () => {
  let component: CrearListaPrecioProductoComponent;
  let fixture: ComponentFixture<CrearListaPrecioProductoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearListaPrecioProductoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearListaPrecioProductoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
