import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoaderFaktumComponent } from './loader-faktum.component';

describe('LoaderFaktumComponent', () => {
  let component: LoaderFaktumComponent;
  let fixture: ComponentFixture<LoaderFaktumComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoaderFaktumComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoaderFaktumComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
