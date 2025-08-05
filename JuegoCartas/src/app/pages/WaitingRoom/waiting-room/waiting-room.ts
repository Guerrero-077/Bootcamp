import { CommonModule } from '@angular/common';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDialog } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import Swal from 'sweetalert2';
import { AddPlayerModal } from '../../../Components/add-player-modal/add-player-modal';
import { GameService } from '../../../Service/Game/game-service';
import { insertImport } from '@angular/cdk/schematics';
import { Player } from '../../../Models/Player.models';
import { DeckService } from '../../../Service/Deck/deck-service';
import { GeneralService } from '../../../Service/general/general-service';

@Component({
  selector: 'app-waiting-room',
  imports: [
    CommonModule,
    MatButtonModule, MatIconModule
  ],
  templateUrl: './waiting-room.html',
  styleUrl: './waiting-room.css'
})
export class WaitingRoom implements OnInit {
  users: Player[] = [];

  constructor(
    private apiService: GeneralService,
    private dialog: MatDialog,
    private cdr: ChangeDetectorRef,
    private game: GameService,
    private deckService: DeckService
  ) {

  }
  ngOnInit() {
    this.cargarUsers();

  }



  openAddPlayerModal(): void {
    const dialogRef = this.dialog.open(AddPlayerModal, {
      panelClass: 'no-backdrop-dialog',
      backdropClass: 'transparent-backdrop',

      autoFocus: false,
      height: 'auto',
      width: 'auto',

    });

    dialogRef.afterClosed().subscribe((name: string) => {
      if (name) {
        var data = {
          name: name
        }
        this.apiService.Crear('Player', data).subscribe(() => {
          this.cargarUsers();
        })
      }
    });
  }

  cargarUsers() {
    this.apiService.getAll('Player').subscribe((data) => {
      this.users = data;
    })
  }

  delete(id: number) {
    Swal.fire({
      title: '¿Estás seguro?',
      text: 'Esta acción eliminará el jugador.',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Sí, eliminar',
      cancelButtonText: 'Cancelar',
    }).then((result) => {
      if (result.isConfirmed) {
        this.apiService.delete('Player', id).subscribe(() => {
          this.cargarUsers();
          Swal.fire('Eliminado', 'El jugador ha sido eliminado.', 'success');
        });
      }
    });
  }

  startGame() {
    if (this.users.length < 2 || this.users.length > 7) {
      Swal.fire({
        title: 'Cantidad inválida',
        text: `El juego debe tener entre 2 y 7 jugadores para poder iniciar.`,
        icon: 'warning',
        confirmButtonText: 'Aceptar'
      })
    }

    this.apiService.getAll('Deck').subscribe((decks) => {
      if (decks.length) {
        this.deckService.deleteAllDecks().subscribe({
          next: () => {
            this.start();
          },
          error: (error) => {
            console.error('Error al eliminar los decks:', error);
          }
        });
      } else {
        this.start();
      }
    });

  }

  start() {
    this.game.CreateGame().subscribe((data) => {
      if (data.success) {
        Swal.fire({
          title: 'Juego Iniciado',
          text: `El juego ha comenzado`,
          icon: 'success',
          confirmButtonText: 'Aceptar'
        }).then(() => {
          window.location.href = `/game`;
        });
      } else {
        Swal.fire({
          title: 'Error',
          text: 'No se pudo iniciar el juego. Inténtalo de nuevo más tarde.',
          icon: 'error',
          confirmButtonText: 'Aceptar'
        });
      }
    }, (error) => {
      Swal.fire({
        title: 'Error',
        text: 'Ocurrió un error al iniciar el juego. Por favor, inténtalo de nuevo.',
        icon: 'error',
        confirmButtonText: 'Aceptar'
      });
    }
    );

  }

}
