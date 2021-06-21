
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
        public subjectId: number = null,
        public price: number = null,
        public userId: number = null,
        public sessions: ISession[] = null
    ){
        super(id, name, description, level, enrollDeadline, subjectId, price, userId);
    }
}