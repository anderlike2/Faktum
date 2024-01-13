import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearOtroProductoComponent } from './crear-otro-producto.component';

describe('CrearOtroProductoComponent', () => {
  let component: CrearOtroProductoComponent;
  let fixture: ComponentFixture<CrearOtroProductoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearOtroProductoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearOtroProductoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
