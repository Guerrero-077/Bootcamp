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
import Swal from "sweetalert2";

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
  playerCard: GamePlayerViewModel[] = [];
  atributoRonda!: any;
  cartasDeshabilitadas: any[] = [];

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
        next: (data) => (
          this.cardsPlayer = data
        ),
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
    this.playerCard.push(event);
    this.cardSelect.push(event.card);

    let cartaId = event.card?.id;
    if (cartaId) {
      this.cardsPlayer = this.cardsPlayer.filter(carta => carta.card.id !== cartaId);
    }
    this.cartasDeshabilitadas.push({ id: cartaId, deshabilitada: true });
  }

  //Método para cerrar modal
  closeModal() {
    this.modalVisible = false;
  }


  eliminarCartaJugador(playerId: number): void {
    const index = this.cardsPlayer.findIndex(p => p.playerId === playerId);
    if (index !== -1) {
      this.playerCard.splice(index, 1); // Remueve de cartas jugadas
      this.cardSelect.splice(index, 1); // Remueve del array de selección
    }
  }

  FinalizarRonda() {
    this.asignarPuntajeGanador();
    this.roundNumber++;
    this.jugadoresQueJugaron = [];
    this.playerCard = [];
    this.cardSelect = [];
    this.iniciarRonda();
    if (this.roundNumber >= 8) {
      Swal.fire({
        title: 'Juego finalizado!',
        // text: `🏆 El ganador es: ${jugadorGanador.player.playerName}`,
        icon: 'success',
        confirmButtonText: 'Aceptar'
      });
    }
  }


  asignarPuntajeGanador(): void {
    const atributoMap: { [nombre: string]: string } = {
      'Fuerza': 'force',
      'Velocidad': 'speed',
      'IQ': 'iq',
      'Popularidad': 'popularity',
      'Resistencia': 'resistance',
      'Apariciones': 'appearances'
    };

    let atributoKey = atributoMap[this.atributoRonda.nombre];
    if (!atributoKey) {
      console.error('Atributo no reconocido:', this.atributoRonda);
      return;
    }

    let cartaGanadora = this.cardSelect.reduce((max, actual) => {
      return (actual as any)[atributoKey] > (max as any)[atributoKey] ? actual : max;
    });

    let puntaje = (cartaGanadora as any)[atributoKey]

    let jugadorGanador = this.playerCard.find(p => p.card?.id === cartaGanadora.id);

    if (jugadorGanador?.player?.playerName) {
      jugadorGanador.player.winner += puntaje;
      Swal.fire({
        title: '¡Ronda finalizada!',
        text: `🏆 El ganador es: ${jugadorGanador.player.playerName}: ${puntaje} `,
        icon: 'success',
        confirmButtonText: 'Aceptar'
      });
    }

    // Eliminar cartas de la ronda
    this.playerCard = [];
  }



  FinalizatTurno(jugador: GamePlayerModel): void {
    if (!jugador?.playerId) return;

    // Solo agregamos el jugador al arreglo mientras no se encuentre
    if (!this.jugadoresQueJugaron.includes(jugador.playerId)) {
      this.jugadoresQueJugaron.push(jugador.playerId);
    }

    // Condicional
    const todosJugaron = this.jugadoresQueJugaron.length === this.gamePlayers.length;

    if (todosJugaron) {
      this.FinalizarRonda();
    } else {
      this.pasarTurnoAlSiguienteJugador();
    }
  }


  pasarTurnoAlSiguienteJugador(): void {
    const jugadoresRestantes = this.gamePlayers.filter(
      p => !this.jugadoresQueJugaron.includes(p.playerId)
    );

    const siguienteJugador = jugadoresRestantes[0];

    this.currentTurnPlayerId = siguienteJugador.id;
  }

}

