import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPlayerModal } from './add-player-modal';

describe('AddPlayerModal', () => {
  let component: AddPlayerModal;
  let fixture: ComponentFixture<AddPlayerModal>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddPlayerModal]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddPlayerModal);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
