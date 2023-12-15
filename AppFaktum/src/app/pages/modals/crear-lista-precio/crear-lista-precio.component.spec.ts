import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearListaPrecioComponent } from './crear-lista-precio.component';

describe('CrearListaPrecioComponent', () => {
  let component: CrearListaPrecioComponent;
  let fixture: ComponentFixture<CrearListaPrecioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearListaPrecioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearListaPrecioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
