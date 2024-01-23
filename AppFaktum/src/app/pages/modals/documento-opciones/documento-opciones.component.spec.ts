import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DocumentoOpcionesComponent } from './documento-opciones.component';

describe('DocumentoOpcionesComponent', () => {
  let component: DocumentoOpcionesComponent;
  let fixture: ComponentFixture<DocumentoOpcionesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DocumentoOpcionesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DocumentoOpcionesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
