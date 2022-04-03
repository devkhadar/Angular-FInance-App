import { Component, OnInit } from '@angular/core';
import { RegistrationService } from '../registration.service';
import { IRegistration } from '../iregistration';
import { Router } from '@angular/router';
import { FormControl, FormGroup, NgForm } from '@angular/forms';
import { LoginService } from '../login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  constructor(private loginService: LoginService, private router: Router) {}

  ngOnInit(): void {
    sessionStorage.clear();
  }
  onLogin(loginForm: NgForm): void {
    this.loginService.authenticate(loginForm.value).subscribe({
      next: (data) => {
        data.role = loginForm.value?.type.toUpperCase();
        sessionStorage.setItem('finUser', JSON.stringify(data));
        if (loginForm.value?.type.toLowerCase() === 'admin')
          this.router.navigate(['/']);
        else this.router.navigate(['/userdashboard']);
      },
      error: (error) => {
        alert('Invalid username or password');
        sessionStorage.clear();
      },
    });
  }
}
