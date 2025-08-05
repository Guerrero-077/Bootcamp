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


  // ngOnInit(): void {
  //   if (!this.card) {
  //     this.cardService.getAll().subscribe({
  //       next: (data) => (this.card = data),
  //       error: (err) => console.error('Error al cargar cartas', err),
  //     });
  //   }
  // }
}


// @Output() attributeSelected = new EventEmitter<{ card: CardModel; attribute: string }>();
// @Output() attributeSelected = new EventEmitter<{ card: CardModel }>();


//  @Output() cerrarModal = new EventEmitter<void>();

//  cerrar() {
//    this.cerrarModal.emit();
//  }

// onAttributeClick(card: CardModel): void {
//   this.attributeSelected.emit({ card, attribute });
//   this.attributeSelected.emit({ card});
//   console.log('Card clicked:', card);
//    this.cerrar();
// }


// private readonly cardService = inject(CardService);

