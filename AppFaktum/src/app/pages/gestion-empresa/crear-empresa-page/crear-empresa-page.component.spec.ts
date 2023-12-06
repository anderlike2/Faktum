import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearEmpresaPageComponent } from './crear-empresa-page.component';

describe('CrearEmpresaPageComponent', () => {
  let component: CrearEmpresaPageComponent;
  let fixture: ComponentFixture<CrearEmpresaPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearEmpresaPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearEmpresaPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
