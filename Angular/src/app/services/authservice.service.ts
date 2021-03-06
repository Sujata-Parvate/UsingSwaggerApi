import { Injectable } from '@angular/core';
import{HttpClient,HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserModel } from '../user/UserModel';

@Injectable({
  providedIn: 'root'
})
export class AuthserviceService {

  public token:string="";
  public userModel:UserModel=new UserModel();
  public event_id:string="";
  constructor(private http : HttpClient) {

   }

  // readonly BaseURL='https://servicew.wheebox.com/WheeboxRestService_blob/'
 // readonly BaseURL='https://servicew.wheebox.com/WheeboxRestService_blob/'

 readonly BaseURL='https://localhost:44317/api/'
   SignUp(data:any){
     debugger;
     let AuthHeader=new HttpHeaders();
     AuthHeader.append('Access-Control-Allow-Origin','*');
    return this.http.post("https://localhost:44317/api/UserToken/GetToken",data);
  }

 
   postApi(data:any,method:any){
     debugger;
     let AuthHeader=new HttpHeaders();
     AuthHeader.append('Access-Control-Allow-Origin','*');
     AuthHeader.append('Authorization',this.token);
    return this.http.post(this.BaseURL+"/"+method,data,{headers:AuthHeader});
  }

  StudentRegistration(data:any){
    debugger;
    let AuthHeader=new HttpHeaders({'Authorization': this.token});
   return this.http.post(this.BaseURL +"UserToken/getRegistration" ,data,{headers:AuthHeader})
  
  }

}

