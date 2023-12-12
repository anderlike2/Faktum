import { TestBed } from '@angular/core/testing';

import { LoaderFaktumInterceptor } from './loader-faktum.interceptor';

describe('LoaderFaktumInterceptor', () => {
  beforeEach(() => TestBed.configureTestingModule({
    providers: [
      LoaderFaktumInterceptor
      ]
  }));

  it('should be created', () => {
    const interceptor: LoaderFaktumInterceptor = TestBed.inject(LoaderFaktumInterceptor);
    expect(interceptor).toBeTruthy();
  });
});
