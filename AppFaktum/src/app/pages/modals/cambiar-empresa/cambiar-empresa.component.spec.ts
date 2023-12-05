import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CambiarEmpresaComponent } from './cambiar-empresa.component';

describe('CambiarEmpresaComponent', () => {
  let component: CambiarEmpresaComponent;
  let fixture: ComponentFixture<CambiarEmpresaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CambiarEmpresaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CambiarEmpresaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
