import { ISession } from "./ISession";
import { IWebinar } from "./IWebinar";

export interface IWebinarWithSessions extends IWebinar{
    sessions: ISession[];
}