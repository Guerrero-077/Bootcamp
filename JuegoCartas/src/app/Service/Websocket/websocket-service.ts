import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';

@Injectable({
  providedIn: 'root'
})
export class WebsocketService {
  connection!: signalR.HubConnection; 

  public connect(): Promise<void> {
    this.connection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:7219/gamehub')
      .withAutomaticReconnect()
      .build();

    return this.connection.start()
      .then(() => console.log('Conexión exitosa'))
      .catch(err => console.error('Error al conectar', err));
  }


  sendMessage(message: string) {
    this.connection.invoke('Joined', message)
      .catch(err => console.error('Error al enviar mensaje', err));

  }

  onMessageReceived(callback: (message: string) => void) {
    this.connection.on('PlayerJoined', callback);

  }
}
