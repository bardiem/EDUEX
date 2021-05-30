import { ICreateWebinar } from './ICreateWebinar';

export interface IWebinar extends ICreateWebinar {
    id: number;
    enrollDeadline: Date;
}