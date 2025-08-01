import { Component } from '@angular/core';
import { Websocket } from '../../Services/websocket';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {
  constructor(public signalr: Websocket) { }

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
