import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-forgetpassword',
  templateUrl: './forgetpassword.component.html',
  styleUrls: ['./forgetpassword.component.css']
})
export class ForgetpasswordComponent implements OnInit {

  constructor() {}
  isOTP: boolean = false;
  ngOnInit(): void {}

  submit(event: any) {
    event.preventDefault();
    this.isOTP = !this.isOTP;
  }

}
