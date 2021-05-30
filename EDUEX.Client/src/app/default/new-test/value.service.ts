import { HttpClient, HttpHeaderResponse } from "@angular/common/http";
import {Injectable } from "@angular/core";
import { Observable } from "rxjs";


@Injectable({providedIn: "root"})
export class NewTestService {
    constructor(private http: HttpClient)
    {   
    }

    get(){
        return this.http.get<string[]>("api/value");    
    }
}