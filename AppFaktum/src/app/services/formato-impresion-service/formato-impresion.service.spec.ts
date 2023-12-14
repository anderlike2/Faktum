import { TestBed } from '@angular/core/testing';

import { FormatoImpresionService } from './formato-impresion.service';

describe('FormatoImpresionService', () => {
  let service: FormatoImpresionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FormatoImpresionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
