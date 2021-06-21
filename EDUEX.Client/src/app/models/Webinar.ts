import { IWebinar } from "./IWebinar";

export class Webinar implements IWebinar {
    constructor(
        public id: number = null,
        public name: string = null,
        public description: string = null,
        public level: number = null,
        public enrollDeadline: Date = null,
        public subjectId: number = null,
        public price: number = null,
        public userId: number = null
    ){}
}