import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry, switchMap } from 'rxjs/operators';
import { AuthService } from '../../services/auth-service/auth.service';
import { IResAuthToken } from 'src/app/models/auth.model';

@Injectable()
export class InterceptorFaktum implements HttpInterceptor {

  constructor(
    private authService: AuthService
  ) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    if (request.url.endsWith('/AuthToken')) {
      return next.handle(request);
    }

    return this.authService.obtenerClave().pipe(
      retry(1),
      switchMap((response: IResAuthToken) => {
        const newRequest = request.clone({
          setHeaders: {
            Authorization: `Bearer ${response.token}`
          }
        });

        return next.handle(newRequest);
      })
    );


  }
}
