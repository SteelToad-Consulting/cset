
import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable()
export class IdsInterceptor implements HttpInterceptor {

  constructor() {
  }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    const assessmentId = localStorage.getItem("assessmentId") ?? "-1";
    const aggregationId = localStorage.getItem("aggregationId") ?? "-1";

    const newRequest = request.clone({
     headers: request.headers.set("Content-Type", 'application/json')
        .set("CSET_ASSESSMENT_ID", assessmentId)
        .set("CSET_AGGREGATION_ID", aggregationId)
    });

    return next.handle(newRequest);
  }
}
