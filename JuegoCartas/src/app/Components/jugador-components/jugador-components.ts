import { CommonModule } from '@angular/common';
import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { CardModel } from '../../Models/Cards.models';
import { GamePlayerModel } from '../../Models/GamePlayer.models';
import { CardService } from '../../Service/Card/card-service';
import { DeckService } from '../../Service/Deck/deck-service';
import { CardComponent } from "../card-component/card-component";

@Component({
  selector: 'app-jugador-components',
  imports: [CommonModule, MatCardModule, CardComponent],
  templateUrl: './jugador-components.html',
  styleUrl: './jugador-components.css'
})
export class JugadorComponents {



  // Simular arreglo para icono de cartas
  readonly cardIndexes = Array.from({ length: 4 }, (_, i) => i);

  // Servicios principales
  private readonly deckService = inject(DeckService);
  private readonly cardService = inject(CardService);

  // Modelos
  @Input() models?: GamePlayerModel;
  selectedCard: any = null;
  modalVisible: boolean = false;
  cards: CardModel[] = [];

  // cardSelect: CardModel[] = [];


  @Output() cardSelected = new EventEmitter<{ playerId: number, card: CardModel }>();

  Card(event: CardModel) {
    if (this.models?.playerId !== undefined) {
      this.cardSelected.emit({
        playerId: this.models.playerId,
        card: event
      });
    }
  }

  // Card(event: CardModel) {
  //   this.cards.push(event);
  //   console.log(this.cards);
  // }



  openCardModal() {
    if (this.models?.playerId !== undefined) {
      this.deckService.getDecksByPlayer(this.models.playerId).subscribe({
        next: (data) => {
          this.cards = data.map(deck => deck.card);
          // console.log(data);
          this.modalVisible = true;
        },
        error: (err) => {
          console.error('Error al obtener cartas del jugador', err);
        }
      });
    } else {
      console.error('playerId is undefined');
    }
  }



  closeModal() {
    this.modalVisible = false;
    this.selectedCard = null;
  }



  ngOnInit(): void {
    if (!this.cards) {
      this.cardService.getAll().subscribe({
        next: (data) => (this.cards = data),
        error: (err) => console.error('Error al cargar cartas', err),
      });
    }
  }
}
