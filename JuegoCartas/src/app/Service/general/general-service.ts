import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GeneralService {
    constructor(private http: HttpClient) { }

  private UrlBase = environment.apiUrl;

  public getAll(entidad: string) {
    return this.http.get<any>(`${this.UrlBase}${entidad}`);
  }
  public ObtenerActivos(entidad: string) {
    return this.http.get<any>(`${this.UrlBase}/${entidad}/active`);
  }
  public Crear(entidad: string, objeto: any) {
    return this.http.post<any>(`${this.UrlBase}${entidad}`, objeto);
  }
  public update(entidad: string, data: any) {
    return this.http.put(`${this.UrlBase}${entidad}/update/`, data);
  }
  public delete(entidad: string, id: number) {
    return this.http.delete(`${this.UrlBase}${entidad}/${id}`);
  }
}
