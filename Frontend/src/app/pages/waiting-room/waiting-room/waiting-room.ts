import { CommonModule } from '@angular/common';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { GeneralService } from '../../../Services/general/general-service';
import { MatDialog } from '@angular/material/dialog';
import { AddPlayerModal } from '../../../Components/add-player-modal/add-player-modal';
import { MatButtonModule } from '@angular/material/button';
import Swal from 'sweetalert2';

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
    private cdr: ChangeDetectorRef
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
}
//
