import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';
import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { CardModel } from '../../Models/Cards.models';
import { GamePlayerModel } from '../../Models/GamePlayer.models';
import { CardService } from '../../Service/Card/card-service';
import { Ronda } from '../../Models/round.models';
import { CardComponent } from '../card-component/card-component';
import { DeckService } from '../../Service/Deck/deck-service';
import { GamePlayerViewModel } from '../../Models/GamePlayerViewModel .model';

@Component({
  selector: 'app-jugador-components',
  imports: [CommonModule,
    MatButtonModule,
    MatCardModule, CardComponent],
  templateUrl: './jugador-components.html',
  styleUrl: './jugador-components.css'
})
export class JugadorComponents {

  // Simular arreglo para icono de cartas
  readonly cardIndexes = Array.from({ length: 4 }, (_, i) => i);
  @Input() atributo!: any;
  @Input() currentTurnPlayerId: number | null = null;

  @Output() emitirRonda: EventEmitter<any> = new EventEmitter();
  @Output() cardsSelecteds: EventEmitter<GamePlayerViewModel> = new EventEmitter();
  @Output() emitirAtributo: EventEmitter<string> = new EventEmitter();


  private readonly deckService = inject(DeckService);
  private readonly cardService = inject(CardService);

  // Modelos
  @Input() models?: GamePlayerModel;
  selectedCard: any = null;
  modalVisible: boolean = false;
  cards: CardModel[] = [];
  arregloCartas: [] = [];
  cardSelect: CardModel[] = [];
  selectedCardIndex: number = 0;

  // cardSelect: CardModel[] = [];


  @Output() cardSelected = new EventEmitter<GamePlayerViewModel>();

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
    this.selectedCardIndex = index;
    this.selectedCard = card;
    // this.Card(card);
    console.log('Carta seleccionada:', card);
  }

  ngOnInit(): void {
    if (this.currentTurnPlayerId == this.models?.playerId) {
      this.openCardModal();
    }

    if (!this.cards) {
      this.cardService.getAll().subscribe({
        next: (data) => (this.cards = data),
        error: (err) => console.error('Error al cargar cartas', err),
      });
    }
  }

 turnMessageVisible = false;

ngOnChanges() {
  this.closeModal();

  if (this.models?.id == this.currentTurnPlayerId) {
    this.turnMessageVisible = true; // mostrar mensaje
    this.openCardModal();

    // ocultarlo después de 2.5 segundos
    setTimeout(() => {
      this.turnMessageVisible = false;
    }, 2500);
  }
}

  SeleccionarAtributo(event: any) {
    this.atributo = event.nombre;
    this.emitirAtributo.emit(event)
  }

  pasarRonda() {
    if (this.atributo) {
      var data: GamePlayerViewModel = {
        player: this.models,
        card: this.selectedCard
      }
      this.cardSelected.emit(data);
      this.emitirRonda.emit()
    }

  }
}
