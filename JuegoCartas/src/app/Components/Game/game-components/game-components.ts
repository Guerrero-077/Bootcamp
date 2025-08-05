import { Component, EventEmitter, inject, Input, OnInit, Output } from "@angular/core";
import { JugadorComponents } from "../../jugador-components/jugador-components";
import { CommonModule } from "@angular/common";
import { CardComponent } from "../../card-component/card-component";
import { GamePlayerService } from "../../../Service/GamePlayer/game-player-service";
import { GamePlayerModel } from "../../../Models/GamePlayer.models";
import { CardModel } from "../../../Models/Cards.models";
import { CardService } from "../../../Service/Card/card-service";
import { DeckService } from "../../../Service/Deck/deck-service";

@Component({
  selector: 'app-game-components',
  imports: [JugadorComponents, CommonModule],
  templateUrl: './game-components.html',
  styleUrl: './game-components.css'
})
export class GameComponents implements OnInit {

  //Servicios
  gamePlayer = inject(GamePlayerService);
  deckService = inject(DeckService);
  cardService = inject(CardService);

  //Modelos
  cards: CardModel[] = [];
  gamePlayers: GamePlayerModel[] = [];
  @Input() models?: GamePlayerModel;


  //Variables
  readonly cardIndexes = Array.from({ length: 4 }, (_, i) => i);
  selectedCard: any = null;
  modalVisible: boolean = false;
  selectedCardsByPlayer = new Map<number, CardModel[]>();



  ngOnInit(): void {
    this.Load();


    if (!this.cards) {
      this.cardService.getAll().subscribe({
        next: (data) => (this.cards = data),
        error: (err) => console.error('Error al cargar cartas', err),
      });
    }
  }

  Load() {
    this.gamePlayer.getAll().subscribe({
      next: (data) => { this.gamePlayers = data },
      error: (err) => { console.log('Error :>> ', err); }
    })
  }

  //Capturar el evento emitido
  Card(event: CardModel) {
    this.cards.push(event);
    console.log(this.cards);
  }

  onCardSelected(event: { playerId: number, card: CardModel }) {
    const { playerId, card } = event;

    if (!this.selectedCardsByPlayer.has(playerId)) {
      this.selectedCardsByPlayer.set(playerId, []);
    }

    const playerCards = this.selectedCardsByPlayer.get(playerId)!;

    // Evita duplicados (opcional)
    const isAlreadySelected = playerCards.some(c => c.id === card.id);
    if (!isAlreadySelected) {
      playerCards.push(card);
    }

    console.log(`Jugador ${playerId} seleccionó`, card);
  }



  //Método para abrir modal
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


  //Método para cerrar modal
  closeModal() {
    this.modalVisible = false;
    this.selectedCard = null;
  }





}

