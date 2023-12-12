import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { debounceTime } from 'rxjs/operators';
import { LoaderService } from 'src/app/services/loader-service/loader.service';

@Component({
  selector: 'app-loader-faktum',
  templateUrl: './loader-faktum.component.html',
  styleUrls: ['./loader-faktum.component.scss']
})
export class LoaderFaktumComponent implements OnInit {
  loaderImg = 'assets/images/shared/loader-faktum.png';
  loading: boolean = false;
  loadingSubscription: Subscription;

  constructor(
    private cargadorService: LoaderService
  ) { }

  ngOnInit() {
    this.loadingSubscription = this.cargadorService.loadingStatus.pipe(
      debounceTime(200)
    ).subscribe((value) => {
      this.loading = value;
    });
  }

  ngOnDestroy() {
    this.loadingSubscription.unsubscribe();
  }

}
