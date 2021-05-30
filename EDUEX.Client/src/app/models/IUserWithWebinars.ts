import { IUser } from "./IUser";
import { IWebinar } from './IWebinar';

export interface IUserWithWebinars extends IUser{
    webinars: IWebinar[];
}