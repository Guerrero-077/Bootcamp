// game-grid.component.ts
import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GamePlayerModel } from '../../Models/GamePlayer.models';
import { JugadorComponents } from '../jugador-components/jugador-components';

@Component({
  selector: 'app-game-grid',
  imports: [CommonModule, JugadorComponents],
  template: `
    <div class="game-container">
      <div class="timer">0:05</div>
      
      <div class="players-grid">
        <div 
          *ngFor="let player of displayPlayers; let i = index" 
          class="player-slot"
          [class.selected]="selectedPlayerId === player?.id"
          [class.empty]="!player"
          (click)="selectPlayer(player, i)"
        >
          <!-- Jugador normal (vista compacta) -->
          <div class="compact-view" *ngIf="selectedPlayerId !== player?.id && player">
            <app-jugador-components [models]="player"></app-jugador-components>
          </div>

          <!-- Vista expandida cuando está seleccionado -->
          <div class="expanded-view" *ngIf="selectedPlayerId === player?.id && player">
            <div class="expanded-header">
              <div class="player-basic-info">
                <div class="score-section">
                  <span class="star">⭐</span>
                  <span class="score">{{ player.winner }}</span>
                </div>
                <div class="player-name">{{ player.playerName }}</div>
              </div>
              <button class="close-btn" (click)="closeExpanded($event)">×</button>
            </div>
            
            <div class="expanded-content">
              <div class="avatar-large">
                <img src="/perfil.png" [alt]="player.playerName" class="avatar-img-large">
              </div>
              
              <div class="player-stats">
                <div class="stat-item">
                  <span class="label">Player ID:</span>
                  <span class="value">{{ player.playerId }}</span>
                </div>
                <div class="stat-item">
                  <span class="label">Game ID:</span>
                  <span class="value">{{ player.gameId }}</span>
                </div>
                <div class="stat-item">
                  <span class="label">Score:</span>
                  <span class="value">{{ player.winner }}</span>
                </div>
              </div>

              <div class="cards-preview">
                <div class="cards-title">Cartas disponibles</div>
                <div class="cards-placeholder">
                  <div class="card-slot" *ngFor="let i of [1,2,3,4]">
                    <div class="card-number">{{ i }}</div>
                  </div>
                </div>
                <div class="cards-note">Click para ver todas las cartas</div>
              </div>
            </div>
          </div>

          <!-- Slot vacío -->
          <div class="empty-slot" *ngIf="!player">
            <div class="empty-content">
              <div class="empty-icon">👤</div>
              <div class="empty-text">Esperando jugador...</div>
            </div>
          </div>
        </div>
      </div>
    </div>
  `,
  styles: [`
    .game-container {
      width: 100%;
      min-height: 100vh;
      background: linear-gradient(135deg, #1a1a2e, #16213e, #0f3460);
      padding: 20px;
      position: relative;
      display: flex;
      flex-direction: column;
      align-items: center;
    }

    .timer {
      background: rgba(0, 0, 0, 0.7);
      color: white;
      padding: 10px 20px;
      border-radius: 15px;
      font-size: 24px;
      font-weight: bold;
      margin-bottom: 20px;
      border: 2px solid rgba(255, 255, 255, 0.2);
    }

    .players-grid {
      display: grid;
      grid-template-columns: repeat(3, 1fr);
      grid-template-rows: repeat(3, 1fr);
      gap: 15px;
      width: 90%;
      max-width: 1200px;
      min-height: 70vh;
    }

    .player-slot {
      position: relative;
      cursor: pointer;
      transition: all 0.3s ease;
      min-height: 200px;
    }

    .player-slot.empty {
      cursor: default;
    }

    .compact-view {
      height: 100%;
      transition: all 0.3s ease;
    }

    .compact-view:hover {
      transform: scale(1.02);
    }

    .expanded-view {
      background: linear-gradient(145deg, #2d1b69, #1a0e3d);
      border: 3px solid #8a2be2;
      border-radius: 15px;
      padding: 15px;
      height: 100%;
      position: relative;
      box-shadow: 0 0 30px rgba(138, 43, 226, 0.4);
      animation: expandIn 0.3s ease-out;
    }

    @keyframes expandIn {
      from {
        transform: scale(0.9);
        opacity: 0;
      }
      to {
        transform: scale(1);
        opacity: 1;
      }
    }

    .expanded-header {
      display: flex;
      justify-content: space-between;
      align-items: flex-start;
      margin-bottom: 15px;
    }

    .player-basic-info {
      display: flex;
      flex-direction: column;
      gap: 8px;
    }

    .score-section {
      display: flex;
      align-items: center;
      gap: 5px;
      color: #ffd700;
      font-weight: bold;
      font-size: 16px;
    }

    .player-name {
      color: white;
      font-weight: bold;
      font-size: 18px;
      background: rgba(0, 0, 0, 0.3);
      padding: 5px 10px;
      border-radius: 8px;
    }

    .close-btn {
      background: rgba(255, 255, 255, 0.2);
      border: none;
      color: white;
      width: 30px;
      height: 30px;
      border-radius: 50%;
      cursor: pointer;
      font-size: 20px;
      display: flex;
      align-items: center;
      justify-content: center;
      transition: all 0.2s ease;
    }

    .close-btn:hover {
      background: rgba(255, 255, 255, 0.3);
      transform: scale(1.1);
    }

    .expanded-content {
      display: flex;
      flex-direction: column;
      gap: 15px;
      height: calc(100% - 60px);
    }

    .avatar-large {
      width: 80px;
      height: 80px;
      border-radius: 50%;
      overflow: hidden;
      border: 4px solid #4a90e2;
      margin: 0 auto;
    }

    .avatar-img-large {
      width: 100%;
      height: 100%;
      object-fit: cover;
    }

    .player-stats {
      display: flex;
      flex-direction: column;
      gap: 8px;
      background: rgba(0, 0, 0, 0.3);
      padding: 12px;
      border-radius: 10px;
    }

    .stat-item {
      display: flex;
      justify-content: space-between;
      align-items: center;
    }

    .label {
      color: #ccc;
      font-size: 12px;
    }

    .value {
      color: white;
      font-weight: bold;
      font-size: 14px;
    }

    .cards-preview {
      flex: 1;
      display: flex;
      flex-direction: column;
      gap: 10px;
    }

    .cards-title {
      color: white;
      font-weight: bold;
      text-align: center;
      font-size: 14px;
    }

    .cards-placeholder {
      display: grid;
      grid-template-columns: repeat(2, 1fr);
      gap: 8px;
      flex: 1;
    }

    .card-slot {
      background: linear-gradient(145deg, #4a90e2, #357abd);
      border-radius: 8px;
      display: flex;
      align-items: center;
      justify-content: center;
      color: white;
      font-weight: bold;
      min-height: 40px;
      border: 2px solid rgba(255, 255, 255, 0.2);
      transition: all 0.2s ease;
    }

    .card-slot:hover {
      transform: translateY(-2px);
      box-shadow: 0 4px 8px rgba(0, 0, 0, 0.3);
    }

    .cards-note {
      color: #ccc;
      font-size: 11px;
      text-align: center;
      font-style: italic;
    }

    .empty-slot {
      background: rgba(255, 255, 255, 0.05);
      border: 2px dashed rgba(255, 255, 255, 0.2);
      border-radius: 15px;
      display: flex;
      align-items: center;
      justify-content: center;
      height: 100%;
    }

    .empty-content {
      text-align: center;
      color: rgba(255, 255, 255, 0.4);
    }

    .empty-icon {
      font-size: 40px;
      margin-bottom: 10px;
    }

    .empty-text {
      font-size: 14px;
    }

    /* Responsive */
    @media (max-width: 768px) {
      .players-grid {
        grid-template-columns: repeat(2, 1fr);
        grid-template-rows: repeat(4, 1fr);
        gap: 10px;
      }
      
      .cards-placeholder {
        grid-template-columns: 1fr;
      }
      
      .player-slot {
        min-height: 150px;
      }
    }

    @media (max-width: 480px) {
      .players-grid {
        grid-template-columns: 1fr;
        grid-template-rows: repeat(6, 1fr);
      }
    }

    /* Estilos para hacer que el componente jugador se vea bien en vista compacta */
    .compact-view ::ng-deep .player-card {
      height: 100%;
      border: 2px solid rgba(255, 255, 255, 0.2);
      transition: all 0.3s ease;
    }

    .compact-view ::ng-deep .player-card:hover {
      border-color: rgba(138, 43, 226, 0.8);
      box-shadow: 0 4px 15px rgba(138, 43, 226, 0.3);
    }
  `]
})
export class GameGridComponent implements OnInit {
  @Input() gamePlayers: GamePlayerModel[] = [];

  selectedPlayerId: number | null = null;
  displayPlayers: (GamePlayerModel | null)[] = [];

  ngOnInit() {
    this.setupDisplayPlayers();
  }

  ngOnChanges() {
    this.setupDisplayPlayers();
  }

  private setupDisplayPlayers() {
    // Crear un array de 9 posiciones para la grilla 3x3
    this.displayPlayers = new Array(9).fill(null);

    // Colocar los jugadores en las primeras posiciones
    this.gamePlayers.forEach((player, index) => {
      if (index < 9) {
        this.displayPlayers[index] = player;
      }
    });
  }

  selectPlayer(player: GamePlayerModel | null, index: number) {
    if (!player) return;

    // Si ya está seleccionado, lo deseleccionamos
    if (this.selectedPlayerId === player.id) {
      this.selectedPlayerId = null;
    } else {
      // Seleccionar el nuevo jugador
      this.selectedPlayerId = player.id;
    }
  }

  closeExpanded(event: Event) {
    event.stopPropagation();
    this.selectedPlayerId = null;
  }
}