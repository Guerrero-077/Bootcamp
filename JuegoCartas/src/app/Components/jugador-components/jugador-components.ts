import { Component, inject, Input } from '@angular/core';
import { Player } from '../../Models/Player.models';
import { CommonModule } from '@angular/common';
import { SimpleModalComponent } from "../Modal/simple-modal-component/simple-modal-component";
import { CardService } from '../../Service/Card/card-service';
import { CardModel } from '../../Models/Cards.models';
import { MatCardModule } from '@angular/material/card';
import { CardComponent } from "../card-component/card-component";

@Component({
  selector: 'app-jugador-components',
  imports: [CommonModule, SimpleModalComponent, MatCardModule, CardComponent],
  templateUrl: './jugador-components.html',
  styleUrl: './jugador-components.css'
})
export class JugadorComponents {

  @Input() player: Player = {
    id: 1,
    name: 'Maria',
    score: 100,
    cardCount: 8,
    position: 1,
    avatar: 'perfil.png'
  };

  private readonly cardService = inject(CardService);


  selectedCard: any = null;
  modalVisible: boolean = false;
  cards: CardModel[] = [];

  openCardModal(card: any) {
    this.cardService.getAll().subscribe({
      next: (data) => {
        this.cards = data.slice(0, 8);
        this.modalVisible = true;
        console.log(this.cards);

      },
      error: (err) => {
        console.error('Error al obtener cartas del jugador', err);
      }
    });
  }

  closeModal() {
    this.modalVisible = false;
    this.selectedCard = null;
  }

  getCards(): number[] {
    return Array(Math.min(this.player.cardCount, 4)).fill(0).map((_, i) => i);
  }
}
