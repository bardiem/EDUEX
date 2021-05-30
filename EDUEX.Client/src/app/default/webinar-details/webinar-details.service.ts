import { HttpClient, HttpHeaderResponse, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ISessin } from "./session";

@Injectable({ providedIn: "root" })
export class SessinService {
    constructor(private http: HttpClient) {
    }

    get(): Observable<ISessin[]> {
        return this.http.get<ISessin[]>("/api/session");
    }

    getSessionID(id) {
        return this.http.get('api/session/' + id);
    }
}