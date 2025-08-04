import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { GamePlayerModel } from '../../Models/GamePlayer.models';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GamePlayerService {
  private urlBase = environment.apiUrl + 'GamePlayer'

  constructor(private http: HttpClient) { }

  getAll(): Observable<GamePlayerModel[]> {
    return this.http.get<GamePlayerModel[]>(this.urlBase);
  }
}
