// import { BrowserModule } from '@angular/platform-browser';
// import { NgModule } from '@angular/core';
// import { FormsModule } from '@angular/forms'; // <-- NgModel lives here
// import { CommonModule } from '@angular/common';

// import { AppComponent } from './app.component';
// import { HeroesComponent } from './heroes/heroes/heroes.component';
// import { RegistrationFormComponent } from './registration-form/registration-form/registration-form.component';

// @NgModule({
//   declarations: [
//     AppComponent,
//     HeroesComponent,
//     RegistrationFormComponent
//   ],
//   imports: [
//     BrowserModule,
//     FormsModule,
//     CommonModule
//   ],
//   providers: [],
//   bootstrap: [AppComponent]
// })
// export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
// import { RegistrationFormComponent } from './registration-form/registration-form.component';

@NgModule({
  imports:      [ BrowserModule, FormsModule ],
  declarations: [ 
     
    // RegistrationFormComponent
   ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
