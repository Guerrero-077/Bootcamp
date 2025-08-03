import { TestBed } from '@angular/core/testing';

import { CardServices } from './card-services';

describe('CardServices', () => {
  let service: CardServices;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CardServices);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
