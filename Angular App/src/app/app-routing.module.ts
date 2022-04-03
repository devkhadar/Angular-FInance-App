import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboard } from './AdminDashboard/admindashboard.component';
import { AuthGuard } from './authguard';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { Role } from './Role';
import { UserDashboard } from './User Dashboard/user.component';

const routes: Routes = [
  {
    path: '',//Admin Dashboard
    component: AdminDashboard,
    canActivate: [AuthGuard],
    data: { roles: [Role.Admin] },
  },
  { path: 'registration', component: RegistrationComponent },
  { path: 'login', component: LoginComponent },
  {
    path: 'userdashboard',
    canActivate: [AuthGuard],
    component: UserDashboard,
    data: [Role.User],
  },
  { path: '**', component: LoginComponent, redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
