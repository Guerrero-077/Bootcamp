import { CommonModule } from '@angular/common';
import { Component, Input, Output, EventEmitter } from '@angular/core';
@Component({
  selector: 'app-simple-modal-component',
  imports: [CommonModule],
  templateUrl: './simple-modal-component.html',
  styleUrl: './simple-modal-component.css'
})
export class SimpleModalComponent {
  @Input() visible: boolean = false;
  @Output() close = new EventEmitter<void>();

  onClose() {
    this.close.emit();
  }
}
