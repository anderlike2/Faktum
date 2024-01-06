import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CentroCostosComponent } from './centro-costos.component';

describe('CentroCostosComponent', () => {
  let component: CentroCostosComponent;
  let fixture: ComponentFixture<CentroCostosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CentroCostosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CentroCostosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
