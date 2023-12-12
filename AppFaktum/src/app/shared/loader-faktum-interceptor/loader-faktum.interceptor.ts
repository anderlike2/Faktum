import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoaderService } from 'src/app/services/loader-service/loader.service';
import { finalize } from 'rxjs/operators';

@Injectable()
export class LoaderFaktumInterceptor implements HttpInterceptor {

  activeRequests = 0;
  skipUrls = [];

  constructor(
    private loaderService: LoaderService
  ) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    let displayLoadingScreen = true;

    for (const skippUrl of this.skipUrls) {
      if (new RegExp(skippUrl).test(request.url)) {
          displayLoadingScreen = false;
          break;
      }
  }

  if (displayLoadingScreen) {
        if (this.activeRequests === 0) {
            this.loaderService.startLoading();
        }
        this.activeRequests++;

        return next.handle(request).pipe(
            finalize(() => {
                this.activeRequests--;
                if (this.activeRequests === 0) {
                    this.loaderService.stopLoading();
                }
            })
        );
    } else {
        return next.handle(request);
    }
  }
}
