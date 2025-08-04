import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaComponents } from './lista-components';

describe('ListaComponents', () => {
  let component: ListaComponents;
  let fixture: ComponentFixture<ListaComponents>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ListaComponents]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListaComponents);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
