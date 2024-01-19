import { TestBed } from '@angular/core/testing';

import { ResolucionSucursalService } from './resolucion-sucursal.service';

describe('ResolucionSucursalService', () => {
  let service: ResolucionSucursalService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ResolucionSucursalService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
