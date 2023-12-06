import {Component, OnInit} from '@angular/core';
import {NgbDropdownConfig} from '@ng-bootstrap/ng-bootstrap';
import { StorageService } from 'src/app/services/storage-service/storage.service';

@Component({
  selector: 'app-nav-right',
  templateUrl: './nav-right.component.html',
  styleUrls: ['./nav-right.component.scss'],
  providers: [NgbDropdownConfig]
})
export class NavRightComponent implements OnInit {

  constructor(
    private storageService: StorageService
  ) { }

  ngOnInit() { }

  get infoUsuario() {
    return this.storageService.getUsuarioStorage();
  }
}
