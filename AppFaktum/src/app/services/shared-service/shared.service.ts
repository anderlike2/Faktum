import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private collapseSidebar = new BehaviorSubject<boolean>(true);
  collapseSidebarListener$ = this.collapseSidebar.asObservable();
  collapseSidebarValue$ = this.collapseSidebar;

  constructor() { }

  addCollapseSidebar(bool: boolean) {
    this.collapseSidebar.next(bool);
  }
}
