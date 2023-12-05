import {Component, OnInit} from '@angular/core';
import {NavigationEnd, Router} from '@angular/router';
import { SessionService } from './services/session-service/session.service';
import { StorageService } from './services/storage-service/storage.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CambiarEmpresaComponent } from './pages/modals/cambiar-empresa/cambiar-empresa.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  constructor(
    private sessionService: SessionService,
    private storageService: StorageService,
    private modalService: NgbModal,
    private router: Router
    ) { }

  ngOnInit() {
    this.router.events.subscribe((evt) => {
      if (!(evt instanceof NavigationEnd)) {
        return;
      }
      window.scrollTo(0, 0);
    });

    this.validarEmpresa();
  }

  validarEmpresa() {
    if (this.sessionService.isLogged && !this.sessionService.isActiveEmpresa) {
      this.modalService.open(
        CambiarEmpresaComponent, {
          backdrop: 'static',
          keyboard: false,
          centered: true,
          size: 'xl'
        }
      );
    }
  }
}
