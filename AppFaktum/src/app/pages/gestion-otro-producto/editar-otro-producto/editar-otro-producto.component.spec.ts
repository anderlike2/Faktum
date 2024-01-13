import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarOtroProductoComponent } from './editar-otro-producto.component';

describe('EditarOtroProductoComponent', () => {
  let component: EditarOtroProductoComponent;
  let fixture: ComponentFixture<EditarOtroProductoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarOtroProductoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarOtroProductoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
