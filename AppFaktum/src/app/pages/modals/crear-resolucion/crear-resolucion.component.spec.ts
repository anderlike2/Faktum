import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearResolucionComponent } from './crear-resolucion.component';

describe('CrearResolucionComponent', () => {
  let component: CrearResolucionComponent;
  let fixture: ComponentFixture<CrearResolucionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearResolucionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearResolucionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
