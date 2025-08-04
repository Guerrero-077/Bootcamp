import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@microsoft/signalr';
import { Observable } from 'rxjs';
import { GamePlayerModel } from '../../Models/GamePlayer.models';

@Injectable({
  providedIn: 'root'
})
export class GamePlayerService {
  private urlBase = environment.apiUrl + 'GamePlayer'

  constructor(http: HttpClient) { }

}
