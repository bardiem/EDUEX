import { HttpClient, HttpHeaderResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { IWebinar } from "./webinar";

@Injectable({ providedIn: "root" })
export class WebinrListService {
    constructor(private http: HttpClient) {
    }

    get(): Observable<IWebinar[]>  {
        return this.http.get<IWebinar[]>("/api/webinar");
    }

    getWebinarID(id): Observable<IWebinar>  {
        return this.http.get<IWebinar>('api/webinar/' + id);
    }
}