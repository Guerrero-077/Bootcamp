import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-add-player-modal',
  imports: [
    CommonModule,
      FormsModule,
      MatButtonModule
  ],
  templateUrl: './add-player-modal.html',
  styleUrl: './add-player-modal.css'
})
export class AddPlayerModal {
 playerName = '';

  constructor(public dialogRef: MatDialogRef<AddPlayerModal>) {}

  onSubmit(): void {
    if (this.playerName.trim()) {
      this.dialogRef.close(this.playerName);
    }
  }

  onClose(): void {
  this.dialogRef.close();
}
}
