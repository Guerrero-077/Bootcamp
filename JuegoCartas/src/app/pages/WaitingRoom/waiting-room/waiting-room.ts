import { CommonModule } from '@angular/common';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDialog } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { GeneralService } from '../../../Service/general/general-service';
import { AddPlayerModal } from '../../../Components/add-player-modal/add-player-modal';
import Swal from 'sweetalert2';
import { GameService } from '../../../Service/Game/game-service';
import { insertImport } from '@angular/cdk/schematics';


interface User {
  id: number;
  name: string;
  avatar: string; // Opcional para iconos personalizados
}

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
  users: User[] = [];

  constructor(
    private apiService: GeneralService,
    private dialog: MatDialog,
    private cdr: ChangeDetectorRef,
    private game: GameService
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
    this.game.CreateGame().subscribe((data) => {
      if (data.success) {
        Swal.fire({
          title: 'Juego Iniciado',
          text: `El juego ha comenzado con ID: ${data.gameId}`,
          icon: 'success',
          confirmButtonText: 'Aceptar'
        }).then(() => {
          // Aquí puedes redirigir a la página del juego o realizar otra acción
          // window.location.href = `/game/${data.gameId}`;
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