import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { CardModel } from '../../Models/Card.models';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardServices {

  private UrlBase = environment.apiUrl + 'Card';

  private http = inject(HttpClient);

  getAll(): Observable<CardModel[]> {
    return this.http.get<CardModel[]>(this.UrlBase);
  }

}
