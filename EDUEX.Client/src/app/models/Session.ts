import { ISession } from "./ISession";

export class Session implements ISession{
    constructor(
        public id: number = null,
        public topic: string = null,
        public endDate: Date = null,
        public link: string = null,
        public startDate: Date = null
    ){}
}