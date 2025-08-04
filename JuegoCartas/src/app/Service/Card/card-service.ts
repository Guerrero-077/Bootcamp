import { Injectable, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { CardModel } from '../../Models/Cards.models';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  private urlBase = environment.apiUrl + 'card';

  constructor(private http: HttpClient) { }

  getAll(): Observable<CardModel[]> {
    return this.http.get<CardModel[]>(this.urlBase);
  }


}
