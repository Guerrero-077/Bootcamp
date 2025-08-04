import { Component, OnInit } from '@angular/core';
import { GamePlayerModel } from '../../Models/GamePlayer.models';
import { GameGridComponent } from "../game-grid-component/game-grid-component";

@Component({
  selector: 'app-lista-components',
  imports: [GameGridComponent],
  templateUrl: './lista-components.html',
  styleUrl: './lista-components.css'
})
export class ListaComponents implements OnInit {
  gamePlayers: GamePlayerModel[] = [];

  ngOnInit() {
    // Tu lógica existente para cargar gamePlayers
    this.loadGamePlayers();
  }

  private loadGamePlayers() {
    // Aquí va tu lógica actual para obtener los jugadores
    // Por ejemplo, desde un servicio:
    // this.gameService.getGamePlayers().subscribe(players => {
    //   this.gamePlayers = players;
    // });

    // O datos mock para pruebas:
    this.gamePlayers = [
      {
        id: 1,
        playerId: 101,
        playerName: 'Mario',
        gameId: 1,
        winner: 100
      },
      {
        id: 2,
        playerId: 102,
        playerName: 'Joan M',
        gameId: 1,
        winner: 85
      },
      {
        id: 3,
        playerId: 103,
        playerName: 'Mauricio',
        gameId: 1,
        winner: 92
      },
      {
        id: 4,
        playerId: 104,
        playerName: 'Ingrid',
        gameId: 1,
        winner: 78
      },
      {
        id: 5,
        playerId: 105,
        playerName: 'Sergio',
        gameId: 1,
        winner: 95
      }
      // Agrega más jugadores según necesites
    ];
  }
}