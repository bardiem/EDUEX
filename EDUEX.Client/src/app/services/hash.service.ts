import { Injectable } from '@angular/core';
import { sha512 } from 'js-sha512';

@Injectable({
    providedIn: 'root'
})
export class HashService{

    getHash(str: string){
        return sha512(str);
    }
    
}