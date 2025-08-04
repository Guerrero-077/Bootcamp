import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GameComponents } from './game-components';

describe('GameComponents', () => {
  let component: GameComponents;
  let fixture: ComponentFixture<GameComponents>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GameComponents]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GameComponents);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
