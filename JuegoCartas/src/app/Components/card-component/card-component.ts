import { CommonModule } from '@angular/common';
import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { CardModel } from '../../Models/Cards.models';
import { CardService } from '../../Service/Card/card-service';

@Component({
  selector: 'app-card-component',
  imports: [MatCardModule, CommonModule],
  templateUrl: './card-component.html',
  styleUrl: './card-component.css'
})
export class CardComponent {

  //Servicios
  cardService = inject(CardService);

  @Input() card!: any;
  @Input() layout: 'grid' | 'horizontal' = 'grid';

  @Output() cardSelected = new EventEmitter<CardModel>();
  CardModelo!: CardModel;

  @Output() clickAtributo = new EventEmitter<any>();


  public getById(id: number) {
    return this.cardService.getById(id).subscribe((data) => {
      this.CardModelo = data;
      this.cardSelected.emit(this.CardModelo);
      // this.click.emit();
      console.log("Evento emitodo" + this.CardModelo);
    });

  }

  atributos = [
    { nombre: 'Fuerza', key: 'force' },
    { nombre: 'Velocidad', key: 'speed' },
    { nombre: 'IQ', key: 'iq' },
    { nombre: 'Popularidad', key: 'popularity' },
    { nombre: 'Resistencia', key: 'resistance' },
    { nombre: 'Apariciones', key: 'appearances' }
  ];

  mostrarInfo(nombre: string, valor: any): void {
    var atributo = {
      nombre: nombre,
      valor: valor
    }
    console.log('Ítem:', nombre);
    console.log('Valor:', valor);
    this.clickAtributo.emit(atributo)
  }


  onCardClick(card: CardModel): void {
    this.cardSelected.emit(card);
    console.log("Carta emitida:", card);
  }
}
