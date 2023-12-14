import { TestBed } from '@angular/core/testing';

import { SucursalClienteService } from './sucursal-cliente.service';

describe('SucursalClienteService', () => {
  let service: SucursalClienteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SucursalClienteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
