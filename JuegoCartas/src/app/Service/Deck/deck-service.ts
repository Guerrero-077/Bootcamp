import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { DeckModel } from '../../Models/Deck.models';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DeckService {
  private readonly urlBase = environment.apiUrl + 'deck';

  constructor(private http: HttpClient) { }

  getDecksWithCardAndPlayer(): Observable<DeckModel[]> {
    return this.http.get<DeckModel[]>(`${this.urlBase + "/GetAllWhitCardPlayer"}`);
  }

  getDecksByPlayer(playerId: number): Observable<DeckModel[]> {
    return this.http.get<DeckModel[]>(`${this.urlBase}/player/${playerId}`);
  }

}
