import { TestBed } from '@angular/core/testing';

import { DetalleEmpresaService } from './cargue-combos.service';

describe('DetalleEmpresaService', () => {
  let service: DetalleEmpresaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DetalleEmpresaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
