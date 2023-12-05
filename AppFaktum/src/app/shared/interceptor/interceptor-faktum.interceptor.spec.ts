import { TestBed } from '@angular/core/testing';

import { InterceptorFaktumInterceptor } from './interceptor-faktum.interceptor';

describe('InterceptorFaktumInterceptor', () => {
  beforeEach(() => TestBed.configureTestingModule({
    providers: [
      InterceptorFaktumInterceptor
      ]
  }));

  it('should be created', () => {
    const interceptor: InterceptorFaktumInterceptor = TestBed.inject(InterceptorFaktumInterceptor);
    expect(interceptor).toBeTruthy();
  });
});
