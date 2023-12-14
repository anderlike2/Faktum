import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearCentroCostosComponent } from './crear-centro-costos.component';

describe('CrearCentroCostosComponent', () => {
  let component: CrearCentroCostosComponent;
  let fixture: ComponentFixture<CrearCentroCostosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearCentroCostosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearCentroCostosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
