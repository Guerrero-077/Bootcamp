import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';
import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { CardModel } from '../../Models/Cards.models';
import { DeckService } from '../../Service/Deck/deck-service';
import { SimpleModalComponent } from '../Modal/simple-modal-component/simple-modal-component';
import { GamePlayerModel } from '../../Models/GamePlayer.models';
import { CardComponent } from "../card-component/card-component";
import { CardService } from '../../Service/Card/card-service';
import { Ronda } from '../../Models/round.models';

@Component({
  selector: 'app-jugador-components',
  imports: [CommonModule,
    MatButtonModule,
    MatCardModule, SimpleModalComponent, CardComponent],
  templateUrl: './jugador-components.html',
  styleUrl: './jugador-components.css'
})
export class JugadorComponents {



  @Input() models?: GamePlayerModel;
  readonly cardIndexes = Array.from({ length: 4 }, (_, i) => i);
  @Input() atributo!: any;
  @Output() emitirRonda: EventEmitter<any> = new EventEmitter();

  private readonly deckService = inject(DeckService);
  private readonly cardService = inject(CardService);

  selectedCard: any = null;
  modalVisible: boolean = false;
  cards: CardModel[] = [];
  arregloCartas: [] = [];
  cardSelect: CardModel[] = [];
  mensaje = 'Selecciona una carta'
  selectedCardIndex: number = 0;

  Card(event: CardModel) {
    this.cardSelect.push(event);
    console.log(this.cardSelect);
  }

  openCardModal() {
    if (this.models?.playerId !== undefined) {
      this.deckService.getDecksByPlayer(this.models.playerId).subscribe({
        next: (data) => {
          this.cards = data.map(deck => deck.card);
          this.selectedCardIndex = 0; // Reset selection
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
    this.selectedCardIndex = 0;
  }

  selectCard(index: number, card: CardModel) {
    this.mensaje = '';
    this.selectedCardIndex = index;
    this.selectedCard = card;
    this.Card(card);
    console.log('Carta seleccionada:', card);
  }

  ngOnInit(): void {
    if (!this.cards) {
      this.cardService.getAll().subscribe({
        next: (data) => (this.cards = data),
        error: (err) => console.error('Error al cargar cartas', err),
      });
    }
  }

  SeleccionarAtributo(event: any) {
    this.atributo = event;
  }

  pasarRonda() {
    this.emitirRonda.emit()
  }

  // handleAttributeSelection(event: { card: CardModel }) {
  //   const { card } = event;
  //   console.log(`Seleccionaste la carta con ID ${card.id}`);
  //   this.selectedCard = card;
  //   this.cardService.getById(card.id).subscribe({
  //     next: (data) => {
  //       this.selectedCard = data;
  //       console.log(data)
  //     },
  //     error: (err) => console.error('Error al obtener la carta', err),
  //   });
  //   // Lógica adicional: quizás cerrar el modal, enviar a backend, comparar, etc.
  // }
  // handleAttributeSelection(event: { card: CardModel; attribute: string }) {
  //   const { card, attribute } = event;
  //   console.log(`Seleccionaste la carta con ID ${card.id} y el atributo ${attribute}`);
  //   this.selectedCard = card;
  //   // Lógica adicional: quizás cerrar el modal, enviar a backend, comparar, etc.
  // }


  // getCards(): number[] {
  //   return Array(Math.min(4)).fill(0).map((_, i) => i);
  // }
}
