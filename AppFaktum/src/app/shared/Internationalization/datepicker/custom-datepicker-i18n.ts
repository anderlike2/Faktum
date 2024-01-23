import { Injectable, inject } from '@angular/core';
import { NgbDateStruct, NgbDatepickerI18n } from '@ng-bootstrap/ng-bootstrap';

const I18N_VALUES = {
  'es': {
    weekdays: ['Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa', 'Do'],
    weekdays_long: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
    months: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Agos', 'Sep', 'Oct', 'Nov', 'Dic'],
  }
};

@Injectable({
  providedIn: 'root'
})
export class CustomDatepickerI18n extends NgbDatepickerI18n {
  // private _i18n = inject(I18n)

  getWeekdayShortName(weekday: number): string {
    return I18N_VALUES['es'].weekdays[weekday - 1];
  }
  getMonthShortName(month: number): string {
    return I18N_VALUES['es'].months[month - 1];
  }
  getMonthFullName(month: number): string {
    return this.getMonthShortName(month);
  }
  getDayAriaLabel(date: NgbDateStruct): string {
    return `${date.day}-${date.month}-${date.year}`;
  }
}
