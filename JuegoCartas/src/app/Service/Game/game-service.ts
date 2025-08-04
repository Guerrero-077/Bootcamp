import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { GameModel } from '../../Models/game.models';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GameService {
  private urlBase = environment.apiUrl + 'Game';

  constructor(private http: HttpClient) {}

  public CreateGame(id: number = 1): Observable<GameModel> {
    return this.http.post<GameModel>(`${this.urlBase}/${id}/start`, { });
  }
}
