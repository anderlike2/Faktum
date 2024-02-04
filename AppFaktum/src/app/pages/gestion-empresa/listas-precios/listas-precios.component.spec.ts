import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListasPreciosComponent } from './listas-precios.component';

describe('ListasPreciosComponent', () => {
  let component: ListasPreciosComponent;
  let fixture: ComponentFixture<ListasPreciosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListasPreciosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListasPreciosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
