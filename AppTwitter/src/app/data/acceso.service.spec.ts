import { TestBed } from '@angular/core/testing';

import { AccesoService } from './acceso.service';

describe('AccesoService', () => {
  let service: AccesoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AccesoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
