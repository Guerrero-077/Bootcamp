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

  //Modelos
  @Input() cards?: CardModel[];

  //Variables
  @Input() layout: 'grid' | 'horizontal' = 'grid';
  CardModelo!: CardModel;

  @Output() click = new EventEmitter<void>();
  @Output() cardSelected = new EventEmitter<CardModel>();



  ngOnInit(): void {
    if (!this.cards) {
      this.cardService.getAll().subscribe({
        next: (data) => (this.cards = data),
        error: (err) => console.error('Error al cargar cartas', err),
      });
    }
  }

  public getById(id: number) {
    return this.cardService.getById(id).subscribe((data) => {
      this.CardModelo = data;
      this.cardSelected.emit(this.CardModelo);
      this.click.emit();
      console.log("Evento emitodo", this.CardModelo);
    });

  }

  onCardClick(card: CardModel): void {
    this.cardSelected.emit(card);
    console.log("Carta emitida:", card);
  }
}
