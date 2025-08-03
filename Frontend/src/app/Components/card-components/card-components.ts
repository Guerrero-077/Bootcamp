import { Component, inject } from '@angular/core';
import { CardModel } from '../../Models/Card.models';
import { CardServices } from '../../Services/Card/card-services';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';

@Component({
  selector: 'app-card-components',
  imports: [MatCardModule, CommonModule],
  templateUrl: './card-components.html',
  styleUrl: './card-components.css'
})
export class CardComponents {
  private cardService = inject(CardServices);
  cards: CardModel[] = [];

  ngOnInit(): void {
    this.cardService.getAll().subscribe({
      next: (data) => (this.cards = data),
      error: (err) => console.error('Error al cargar cartas', err),
    });
  }
}
