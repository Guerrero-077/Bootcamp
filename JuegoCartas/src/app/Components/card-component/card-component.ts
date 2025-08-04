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

  @Input() cards?: CardModel[];
  @Input() layout: 'grid' | 'horizontal' = 'grid';
  @Output() attributeSelected = new EventEmitter<{ card: CardModel; attribute: string }>();

  onAttributeClick(card: CardModel, attribute: string): void {
    this.attributeSelected.emit({ card, attribute });
  }


  // private readonly cardService = inject(CardService);

  // ngOnInit(): void {
  //   if (!this.cards) {
  //     this.cardService.getAll().subscribe({
  //       next: (data) => (this.cards = data),
  //       error: (err) => console.error('Error al cargar cartas', err),
  //     });
  //   }
  // }


}