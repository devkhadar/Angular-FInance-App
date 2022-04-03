import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserService } from '../user.service';

@Component({
  selector: 'AdminDashboard',
  templateUrl: './admindashboard.component.html',
  styleUrls: ['./admindashboard.component.css'],
})
export class AdminDashboard implements OnInit {
  users: any[] = [];
  selectedUser: any;
  isOpen: boolean = false;
  constructor(private userService: UserService) {}

  ngOnInit(): void {
    this.userService.getUsers().subscribe({
      next: (data) => {
        this.users = data;
      },
      error: (error) => {},
    });
  }

  toggleModal(user: any = null) {
    this.isOpen = !this.isOpen;
    if (user) {
      this.selectedUser = user;
    }
  }

  onApproveOrReject(form: NgForm) {
    this.selectedUser.approved = form.value.type === 'Approve';
    this.userService.approveOrReject(this.selectedUser).subscribe(
      (data) => {
        this.users.forEach((u) => {
          if (u.userName === this.selectedUser.userName) {
            u.approved = this.selectedUser.approved;
          }
        });
        this.selectedUser = null;
        this.isOpen = false;
      },
      (err) => {}
    );
  }
}
