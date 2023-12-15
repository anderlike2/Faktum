import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarListaPrecioComponent } from './editar-lista-precio.component';

describe('EditarListaPrecioComponent', () => {
  let component: EditarListaPrecioComponent;
  let fixture: ComponentFixture<EditarListaPrecioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarListaPrecioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarListaPrecioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
