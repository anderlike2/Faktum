import { HttpErrorResponse } from '@angular/common/http';
import { ErrorHandler, Injectable, Injector, NgZone } from '@angular/core';
import { Router } from '@angular/router';
import { StorageService } from '../../services/storage-service/storage.service';
import swal from 'sweetalert2';

@Injectable({ providedIn: 'root' })
export class AppErrorHandler extends ErrorHandler {
  constructor(
    private readonly injector: Injector,
    private zone: NgZone
    ) {
    super();
  }

  handleError(error: any) {
    if (error instanceof HttpErrorResponse) {
      switch (error.status) {
        case 401: {
          this.zone.run(() => {
            const sessionService = this.injector.get<StorageService>(StorageService);
            sessionService.logout();
          });
          break;
        }
        case 404: {
          this.zone.run(() => {
            const router = this.injector.get<Router>(Router);
            router.navigateByUrl('error/error404', { skipLocationChange: true });
          });
          break;
        }
        default: {
          swal.fire(`Error ${error.status}`, error.message, 'error');
          break;
        }
      }
    }

    console.error(error);
  }
}
