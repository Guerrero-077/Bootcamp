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
export class GameComponents implements OnInit{
  gamePlayer = inject(GamePlayerService);
  // Recibimos un arreglo de cartas seleccionadas desde jugador-components.ts
  cardSelect: CardModel[] = [];
  // cardSelect: any[] = [];
  // Arreglo de jugadores
  Cards(){
    return this.cardSelect;
  }

  gamePlayers: GamePlayerModel[] = [];



  @Input() models?: GamePlayerModel;
  readonly cardIndexes = Array.from({ length: 4 }, (_, i) => i);


  private readonly deckService = inject(DeckService);
  private readonly cardService = inject(CardService);

  selectedCard: any = null;
  modalVisible: boolean = false;
  cards: CardModel[] = [];



  //
  Card(event: CardModel){
    this.cardSelect.push(event);
    console.log(this.cardSelect);
  }



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


  FinalizarRonda(){}
}

