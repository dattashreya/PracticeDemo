// import { Component } from '@angular/core';
// import { RouterOutlet } from '@angular/router';
// import { HeroesComponent } from './heroes/heroes/heroes.component';
// import { RegistrationFormComponent } from './registration-form/registration-form/registration-form.component';
// import { BrowserModule } from '@angular/platform-browser';
// import { FormsModule } from '@angular/forms';
// import { CommonModule } from '@angular/common';

// @Component({
//   selector: 'app-root',
//   standalone: true,
//   // imports: [RouterOutlet, HeroesComponent, RegistrationFormComponent],
//   imports: [
//     BrowserModule,
//     FormsModule,
//     CommonModule,
//     RouterOutlet, HeroesComponent, RegistrationFormComponent
//   ],
//   templateUrl: './app.component.html',
//   styleUrl: './app.component.css'
// })
// export class AppComponent {
//   title = 'AngularDemo Ecommerce';
// }

import { Component } from '@angular/core';
import { HeroesComponent } from './heroes/heroes/heroes.component';
// import { RegistrationFormComponent } from './registration-form/registration-form.component';

@Component({
  selector: 'app-root',
  // standalone: true,
  // imports: [ HeroesComponent, RegistrationFormComponent],
  templateUrl: './app.component.html',
  styleUrls: [ './app.component.css' ],
})
export class AppComponent  {
  name = 'MVC';

  onSubmit(formValue: any) {
    console.log(formValue);
  }
}
