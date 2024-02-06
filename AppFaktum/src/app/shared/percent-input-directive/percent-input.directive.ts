import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[percentInput]'
})
export class PercentInputDirective {

  @Input() prefix: string = '';

  private regex: RegExp = new RegExp(/^100(\.0{1,2})?$|^\d{1,2}(\.\d{0,2})?$/);

  private specialKeys: Array<string> = [
    'Backspace', 'Tab', 'End', 'Home', '-', 'ArrowLeft', 'ArrowRight', 'Del', 'Delete', 'Decimal', '.'
  ];

  constructor(private el: ElementRef) { }

  @HostListener('keydown', ['$event'])
  onKeyDown(event: KeyboardEvent) {
    if (this.specialKeys.includes(event.key) || event.key === 'Decimal' || event.key === '.') {
      // Permitir teclas especiales y punto decimal
      if ((event.key === 'Decimal' || event.key === '.') && this.el.nativeElement.value.includes('.')) {
        // Prevenir más de un punto decimal
        event.preventDefault();
      }
      return;
    }

    const current: string = this.el.nativeElement.value;
    const selectionStart = this.el.nativeElement.selectionStart;
    const selectionEnd = this.el.nativeElement.selectionEnd;

    // Simular el valor después de la pulsación de tecla
    const nextValue = current.substring(0, selectionStart) + event.key + current.substring(selectionEnd);

    if (!this.isValid(nextValue)) {
      event.preventDefault(); // Prevenir la pulsación de tecla para valores no válidos
    }
  }

  private isValid(value: string): boolean {
    return this.regex.test(value);
  }
}
