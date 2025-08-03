import { Component, inject, Input } from '@angular/core';
import { Player } from '../../Models/Player.models';
import { CommonModule } from '@angular/common';
import { SimpleModalComponent } from '../Modal/simple-modal-component/simple-modal-component';
import { MatCardModule } from '@angular/material/card';
import { CardComponent } from '../card-component/card-component';
import { DeckService } from '../../Service/Deck/deck-service';
import { CardModel } from '../../Models/Cards.models';

@Component({
  selector: 'app-jugador-components',
  imports: [CommonModule, SimpleModalComponent, MatCardModule, CardComponent],
  templateUrl: './jugador-components.html',
  styleUrl: './jugador-components.css'
})
export class JugadorComponents {

  @Input() player!: Player;

  private readonly deckService = inject(DeckService);

  selectedCard: any = null;
  modalVisible: boolean = false;
  cards: CardModel[] = [];

  openCardModal() {
    this.deckService.getDecksByPlayer(this.player.id).subscribe({
      next: (data) => {
        this.cards = data.map(deck => deck.card); // Mapea a solo las cartas
        this.modalVisible = true;
      },
      error: (err) => {
        console.error('Error al obtener cartas del jugador', err);
      }
    });
  }

  closeModal() {
    this.modalVisible = false;
    this.selectedCard = null;
  }

  getCards(): number[] {
    return Array(Math.min(this.player.cardCount, 4)).fill(0).map((_, i) => i);
  }
}
