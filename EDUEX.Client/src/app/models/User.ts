import { IUser } from "./IUser";

export class User implements IUser{
    constructor(
    public id: number = null,
    public firstName: string = null,
    public lastName: string = null,
    public balance: string = null,
    public roles: string[] = null,
    public birthDate: Date = null,
    public position: string = null,
    public email: string = null
    ){}
}