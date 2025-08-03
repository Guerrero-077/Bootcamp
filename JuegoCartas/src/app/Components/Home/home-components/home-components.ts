import { Component } from '@angular/core';
import { WebsocketService } from '../../../Service/Websocket/websocket-service';

@Component({
  selector: 'app-home-components',
  imports: [],
  templateUrl: './home-components.html',
  styleUrl: './home-components.css'
})
export class HomeComponents {
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
