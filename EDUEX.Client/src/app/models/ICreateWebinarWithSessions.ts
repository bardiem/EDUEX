import { ICreateWebinar } from "./ICreateWebinar";
import { ISession } from "./ISession";

export interface ICreateWebinarWithSessions extends ICreateWebinar{
    sessions: ISession[];
}