import { Component, OnInit } from '@angular/core';
import { RegistrationService } from '../registration.service';
import { IRegistration } from '../iregistration';
import { Router } from '@angular/router';
import { FormControl, FormGroup, NgForm } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css'],
})
export class RegistrationComponent implements OnInit {
  constructor(private project: RegistrationService, private router: Router) {}

  ngOnInit(): void {}
  SubmitData(Data: NgForm) {
    this.project.Adduser(Data.value).subscribe({
      next: (data) => {
        alert('Registration successfull');
        this.router.navigate(['/login']);
      },
      error: (error) => {
        alert(error);
      },
    });
  }
}
