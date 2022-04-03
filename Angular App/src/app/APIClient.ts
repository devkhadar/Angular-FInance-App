import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root',
})
export class APIClient {
  public static baseURL: string = 'http://localhost:44668/api/';
}
