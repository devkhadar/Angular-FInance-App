import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { APIClient } from './APIClient';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  constructor(private httpClient: HttpClient) {}

  authenticate(data: any): Observable<any> {
    return this.httpClient.post(
      `${APIClient.baseURL}${
        data.type?.toLowerCase() === 'admin'
          ? 'loginadmin/login'
          : 'UserRegistration/login'
      }`,
      data
    );
  }
}
