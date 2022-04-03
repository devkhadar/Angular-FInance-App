import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RegistrationService } from './registration.service';
import { HttpClientModule } from '@angular/common/http';
import { FormBuilder, FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './registration/registration.component';
import { ConfirmPasswordValidatorDirective } from 'src/confirmpassword.directive';
import { LoginComponent } from './login/login.component';
import { AdminDashboard } from './AdminDashboard/admindashboard.component';
import { UserDashboard } from './User Dashboard/user.component';

@NgModule({
  declarations: [
    AppComponent,
    UserDashboard,
    RegistrationComponent,
    ConfirmPasswordValidatorDirective,
    LoginComponent,
    AdminDashboard,
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, HttpClientModule],
  providers: [RegistrationService, FormBuilder],
  bootstrap: [AppComponent],
})
export class AppModule {}
