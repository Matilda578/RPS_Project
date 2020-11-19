import { TestBed } from '@angular/core/testing';

import { LeaderslistService } from './leaderslist.service';

describe('LeaderslistService', () => {
  let service: LeaderslistService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LeaderslistService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
