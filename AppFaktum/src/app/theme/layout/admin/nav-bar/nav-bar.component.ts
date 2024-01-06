import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {NextConfig} from '../../../../app-config';
import { SharedService } from 'src/app/services/shared-service/shared.service';
import { StorageService } from 'src/app/services/storage-service/storage.service';
import { IInfoLogoEmpresa } from 'src/app/models/empresa.model';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {
  public flatConfig: any;
  public menuClass: boolean;
  public collapseStyle: string;
  public windowWidth: number;
  public imgLogo: string = 'assets/images/faktum-logo-trans.png';
  public infoEmpresa: IInfoLogoEmpresa;

  @Output() onNavCollapse = new EventEmitter();
  @Output() onNavHeaderMobCollapse = new EventEmitter();

  constructor(
    private storageService: StorageService
  ) {
    this.flatConfig = NextConfig.config;
    this.menuClass = false;
    this.collapseStyle = 'none';
    this.windowWidth = window.innerWidth;
  }

  ngOnInit() {
    const empresa = this.storageService.getEmpresaActivaStorage();
    this.imgLogo = empresa.emprLogo;
    this.infoEmpresa = {
      empresa: empresa.emprNombre,
      nit: empresa.emprNit,
      dv: empresa.emprDv
    };
   }

  toggleMobOption() {
    this.menuClass = !this.menuClass;
    this.collapseStyle = (this.menuClass) ? 'block' : 'none';
  }

  navCollapse() {
    if (this.windowWidth >= 992) {
      this.onNavCollapse.emit();
    } else {
      this.onNavHeaderMobCollapse.emit();
    }
  }

}
