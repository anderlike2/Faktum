import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MostrarInformacionComponent } from './mostrar-informacion.component';

describe('MostrarInformacionComponent', () => {
  let component: MostrarInformacionComponent;
  let fixture: ComponentFixture<MostrarInformacionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MostrarInformacionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MostrarInformacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
