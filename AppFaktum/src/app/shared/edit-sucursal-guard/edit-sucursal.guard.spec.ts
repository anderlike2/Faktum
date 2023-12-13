import { TestBed } from '@angular/core/testing';

import { EditSucursalGuard } from './edit-sucursal.guard';

describe('EditSucursalGuard', () => {
  let guard: EditSucursalGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(EditSucursalGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
