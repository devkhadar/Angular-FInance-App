import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IRegistration } from './iregistration';
import { catchError, throwError } from 'rxjs';
import { APIClient } from './APIClient';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class RegistrationService {
  //dependency injection(to connect the api & angular to use(import)service from app.module) by using htttpclient service
  constructor(private httpClient: HttpClient) {}

  //decide the way to connect the web api & angular
  Adduser(data: any): Observable<any> {
    return this.httpClient.post(`${APIClient.baseURL}UserRegistration/Adduser`, data);
  }

  //  url!: 'http://localhost:44668/api/UserRegistration/';

  //   constructor(private http: HttpClient) { }

  //   getRegList(): Observable<any>
  //   {
  //     return this.http.get<any[]>(this.url + 'Listr')
  //   }

  //   registerUser(Registration: IRegistration):Observable<any>
  //   {
  //     let httpOptions = {
  //       headers: new HttpHeaders({
  //         'Content-Type': 'application/json',

  //       })
  //     };
  //     return this.http.post(this.url + 'signup', Registration, httpOptions);
  //   }

  //   register(username: string, email: string, password: string): Observable<any> {

  //     let httpOptions = {
  //       headers: new HttpHeaders({
  //         'Content-Type': 'application/json',

  //       })
  //     };

  //     return this.http.post(this.url + 'signup', {
  //       username,
  //       email,
  //       password
  //     }, httpOptions);
  //   }

  // handleError(error:HttpErrorResponse) {
  //   let errorMessage='';
  //   errorMessage=error.status+'\n' + error.statusText + '\n'
  //   error.error;
  //   alert(errorMessage)
  //   return throwError(errorMessage)
  // }

  // public testFunction() {
  //   console.log('#12345 Test Function Called');
  // }

  // httpOptions(arg0: string, arg1: { username: string; email: string; password: string; }, httpOptions: any): Observable<any> {
  //   throw new Error('Function not implemented.');
  // }
}
