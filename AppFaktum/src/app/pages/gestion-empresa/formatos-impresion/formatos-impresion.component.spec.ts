import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormatosImpresionComponent } from './formatos-impresion.component';

describe('FormatosImpresionComponent', () => {
  let component: FormatosImpresionComponent;
  let fixture: ComponentFixture<FormatosImpresionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormatosImpresionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormatosImpresionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
