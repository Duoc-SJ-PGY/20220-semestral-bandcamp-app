import { TestBed } from '@angular/core/testing';

import { MiapiService } from './miapi.service';

describe('MiapiService', () => {
  let service: MiapiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MiapiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
