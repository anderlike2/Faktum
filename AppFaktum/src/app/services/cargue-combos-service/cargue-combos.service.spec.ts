import { TestBed } from '@angular/core/testing';

import { CargueCombosService } from './cargue-combos.service';

describe('DetalleEmpresaService', () => {
  let service: CargueCombosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CargueCombosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
