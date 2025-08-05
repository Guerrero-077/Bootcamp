import { Component, EventEmitter, inject, Input, OnInit, Output } from "@angular/core";
import { JugadorComponents } from "../../jugador-components/jugador-components";
import { CommonModule } from "@angular/common";
import { CardComponent } from "../../card-component/card-component";
import { GamePlayerService } from "../../../Service/GamePlayer/game-player-service";
import { GamePlayerModel } from "../../../Models/GamePlayer.models";
import { CardModel } from "../../../Models/Cards.models";
import { CardService } from "../../../Service/Card/card-service";
import { DeckService } from "../../../Service/Deck/deck-service";
import { GamePlayerViewModel } from "../../../Models/GamePlayerViewModel .model";

@Component({
  selector: 'app-game-components',
  imports: [
    CommonModule, JugadorComponents, CardComponent],
  templateUrl: './game-components.html',
  styleUrl: './game-components.css'
})
export class GameComponents implements OnInit {
  //Variables
  readonly cardIndexes = Array.from({ length: 4 }, (_, i) => i);
  selectedCard: any = null;
  modalVisible: boolean = false;
  roundNumber: number = 1;

  gamePlayers: GamePlayerModel[] = [];
  currentTurnPlayerId: number | null = null;
  jugadoresQueJugaron: number[] = [];
  PlayerCard: GamePlayerViewModel[] = [];
  atributoRonda!: string;


  //Servicios
  gamePlayerService = inject(GamePlayerService);

  deckService = inject(DeckService);
  cardService = inject(CardService);


  // Recibimos un arreglo de cartas seleccionadas desde jugador-components.ts
  cardSelect: CardModel[] = [];
  cardsPlayer: any[] = [];

  // Arreglo de jugadores
  Cards() {
    return this.cardSelect;
  }

  ngOnInit(): void {
    this.Load();

    if (!this.Cards) {
      this.cardService.getAll().subscribe({
        next: (data) => (this.cardsPlayer = data),
        error: (err) => console.error('Error al cargar cartas', err),
      });

    }
  }


  iniciarRonda() {
    const ids = this.gamePlayers.map(p => p.id);
    const randomId = ids[Math.floor(Math.random() * ids.length)];
    this.currentTurnPlayerId = randomId;

  }

  Load() {
    return this.gamePlayerService.getAll().subscribe({
      next: (data) => {
        this.gamePlayers = data
        this.iniciarRonda();

      },
      error: (err) => { console.log('Error :>> ', err); }
    })
  }

  CartaSeleccionada(event: any) {
    this.PlayerCard = event;
    this.cardSelect.push(event.card);


  }

  //Método para cerrar modal
  closeModal() {
    this.modalVisible = false;
  }


  eliminarCartaJugador(playerId: number): void {
    const index = this.cardsPlayer.findIndex(p => p.playerId === playerId);
    if (index !== -1) {
      this.PlayerCard.splice(index, 1); // Remueve de cartas jugadas
      this.cardSelect.splice(index, 1); // Remueve del array de selección
    }
  }

  FinalizarRonda() {
    this.asignarPuntajeGanador();
    this.roundNumber++;
    this.jugadoresQueJugaron = [];
    this.PlayerCard = [];
    this.cardSelect = [];
    this.iniciarRonda();
  }
  asignarPuntajeGanador(): void {
    if (!Array.isArray(this.PlayerCard) || this.PlayerCard.length === 0) return;

    // Determinar carta ganadora según el atributo de la ronda
    const cartaGanadora = this.PlayerCard.reduce((prev, curr) => {
      const valorPrev = prev.card?.[this.atributoRonda as keyof CardModel] ?? 0;
      const valorCurr = curr.card?.[this.atributoRonda as keyof CardModel] ?? 0;
      return valorCurr > valorPrev ? curr : prev;
    });

    // Sumar punto al jugador ganador
    const jugadorGanador = this.gamePlayers.find(
      p => p.playerId === cartaGanadora?.player?.playerId
    );
    if (jugadorGanador) {
      jugadorGanador.winner = (jugadorGanador.winner || 0) + 1;
    }

    // Eliminar cartas de la ronda
    this.PlayerCard = [];
  }


  FinalizatTurno(jugador: GamePlayerModel) {
    if (!jugador?.playerId) return;

    if (!this.jugadoresQueJugaron.includes(jugador.playerId)) {
      this.jugadoresQueJugaron.push(jugador.playerId);
    }

    if (this.jugadoresQueJugaron.length >= this.gamePlayers.length) {
      this.FinalizarRonda();
    } else {
      this.iniciarRonda();
    }
  }
}

