import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearFormatoImpresionComponent } from './crear-formato-impresion.component';

describe('CrearFormatoImpresionComponent', () => {
  let component: CrearFormatoImpresionComponent;
  let fixture: ComponentFixture<CrearFormatoImpresionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearFormatoImpresionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearFormatoImpresionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
