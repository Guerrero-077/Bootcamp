import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JugadorComponents } from './jugador-components';

describe('JugadorComponents', () => {
  let component: JugadorComponents;
  let fixture: ComponentFixture<JugadorComponents>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [JugadorComponents]
    })
    .compileComponents();

    fixture = TestBed.createComponent(JugadorComponents);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
