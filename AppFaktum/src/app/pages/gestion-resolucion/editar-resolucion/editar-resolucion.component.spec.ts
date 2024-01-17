import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarResolucionComponent } from './editar-resolucion.component';

describe('EditarResolucionComponent', () => {
  let component: EditarResolucionComponent;
  let fixture: ComponentFixture<EditarResolucionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarResolucionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarResolucionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
