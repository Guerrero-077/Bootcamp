import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { GamePlayerModel } from '../../../Models/GamePlayer.models';
import { WebsocketService } from '../../../Service/Websocket/websocket-service';

@Component({
  selector: 'app-home-components',
  imports: [CommonModule],
  templateUrl: './home-components.html',
  styleUrl: './home-components.css'
})
export class HomeComponents {
  gamePlayers: GamePlayerModel[] = [];

  constructor(public signalr: WebsocketService) { }

  ngOnInit() {
    this.signalr.connect().then(() => {
      this.signalr.onMessageReceived((message: string) => {
        console.log('Mensaje recibido:', message);
      });
    });

  }

  sendMessage() {
    this.signalr.sendMessage('Otro mensaje desde Angular');
  }


}
