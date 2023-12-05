import { TestBed } from '@angular/core/testing';

import { NoEmpresaGuard } from './no-empresa.guard';

describe('NoEmpresaGuard', () => {
  let guard: NoEmpresaGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(NoEmpresaGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
