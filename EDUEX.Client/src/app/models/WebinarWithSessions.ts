
import { ISession } from "./ISession";
import { IWebinarWithSessions } from "./IWebinarWithSessions";
import { Webinar } from "./Webinar";

export class WebinarWithSessions extends Webinar implements IWebinarWithSessions{
    constructor(
        public id: number = null,
        public name: string = null,
        public description: string = null,
        public level: number = null,
        public enrollDeadline: Date = null,
        public subject: string = null,
        public price: number = null,
        public userId: number = null,
        public sessions: ISession[] = null
    ){
        super(id, name, description, level, enrollDeadline, subject, price, userId);
    }
}