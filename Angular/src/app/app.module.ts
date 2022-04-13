import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { RouterModule ,Routes } from '@angular/router'
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';

import{ FormsModule } from '@angular/forms';
import{ HttpClientModule} from '@angular/common/http';
import { AuthserviceService } from './services/authservice.service';
import { WheeboxComponent } from './wheebox/wheebox.component';
import { UserRegComponent } from './user-reg/user-reg.component';
const routes: Routes = [
  {
  path: 'user',
  component: UserComponent,
  },
         {
          path: 'wheebox',
          component:WheeboxComponent,
         },
         {
          path: 'user-reg',
          component:UserRegComponent,
         },
    {
      path: '',
      redirectTo: '/user',
      pathMatch:'full',
    }
  ];
@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    WheeboxComponent,
    UserRegComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    FormsModule,
    HttpClientModule
  ],
  providers: [AuthserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
