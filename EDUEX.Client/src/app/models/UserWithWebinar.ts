import { IUserWithWebinars } from "./IUserWithWebinars";
import { IWebinar } from "./IWebinar";
import { User } from "./User";

export class UserWithWebinar extends User implements IUserWithWebinars{
    constructor(
        public id: number = null,
        public firstName: string = null,
        public lastName: string = null,
        public balance: string = null,
        public roles: string[] = null,
        public birthDate: Date = null,
        public position: string = null,
        public email: string = null,
        public webinars: IWebinar[] = null
    ){
        super(id, firstName, lastName, balance, roles, birthDate, position, email);
    }
}