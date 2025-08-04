import { Component, inject, OnInit } from "@angular/core";
import { JugadorComponents } from "../../jugador-components/jugador-components";
import { CommonModule } from "@angular/common";
import { CardComponent } from "../../card-component/card-component";
import { GamePlayerService } from "../../../Service/GamePlayer/game-player-service";
import { GamePlayerModel } from "../../../Models/GamePlayer.models";

@Component({
  selector: 'app-game-components',
  imports: [JugadorComponents, CommonModule],
  templateUrl: './game-components.html',
  styleUrl: './game-components.css'
})
export class GameComponents implements OnInit{
  gamePlayer = inject(GamePlayerService);

  


  gamePlayers: GamePlayerModel[] = [];



  ngOnInit() {
    this.Load();
    
  }


  Load() {
    this.gamePlayer.getAll().subscribe({
      next: (data) => { this.gamePlayers = data },
      error: (err) => { console.log('Error :>> ', err); }
    })
  }

}

