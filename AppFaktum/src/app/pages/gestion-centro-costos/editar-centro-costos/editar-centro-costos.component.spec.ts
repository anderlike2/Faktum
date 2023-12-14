import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarCentroCostosComponent } from './editar-centro-costos.component';

describe('EditarCentroCostosComponent', () => {
  let component: EditarCentroCostosComponent;
  let fixture: ComponentFixture<EditarCentroCostosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarCentroCostosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarCentroCostosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
