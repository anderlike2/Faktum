import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarListaPreciosProductosComponent } from './editar-lista-precios-productos.component';

describe('EditarListaPreciosProductosComponent', () => {
  let component: EditarListaPreciosProductosComponent;
  let fixture: ComponentFixture<EditarListaPreciosProductosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarListaPreciosProductosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarListaPreciosProductosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
