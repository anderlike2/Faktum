import { TestBed } from '@angular/core/testing';

import { EditGeneralGuard } from './edit-general.guard';

describe('EditGeneralGuard', () => {
  let guard: EditGeneralGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(EditGeneralGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
