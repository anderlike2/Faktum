import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarFormatoImpresionComponent } from './editar-formato-impresion.component';

describe('EditarFormatoImpresionComponent', () => {
  let component: EditarFormatoImpresionComponent;
  let fixture: ComponentFixture<EditarFormatoImpresionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarFormatoImpresionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarFormatoImpresionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
