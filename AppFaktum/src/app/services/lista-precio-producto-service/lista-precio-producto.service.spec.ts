import { TestBed } from '@angular/core/testing';

import { ListaPrecioProductoService } from './lista-precio-producto.service';

describe('ListaPrecioProductoService', () => {
  let service: ListaPrecioProductoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ListaPrecioProductoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
