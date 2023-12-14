import { TestBed } from '@angular/core/testing';

import { ContratoClienteService } from './contrato-cliente.service';

describe('ContratoClienteService', () => {
  let service: ContratoClienteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ContratoClienteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
