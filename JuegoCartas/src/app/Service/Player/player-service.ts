import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Player } from '../../Models/Player.models';

@Injectable({
  providedIn: 'root'
})
export class PlayerService {
  private readonly urlBase = environment.apiUrl + 'player';

  constructor(private http: HttpClient) { }

  getAll(): Observable<Player[]> {
    return this.http.get<Player[]>(this.urlBase);
  }

}
