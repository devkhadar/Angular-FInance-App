import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { APIClient } from './APIClient';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(private httpClient: HttpClient) {}

  getUsers(): Observable<any> {
    return this.httpClient.get(`${APIClient.baseURL}UserRegistration/listr`);
  }

  approveOrReject(data: any): Observable<any> {
    return this.httpClient.put(
      `${APIClient.baseURL}UserRegistration/listr/${data.userName}`,
      data
    );
  }
}
