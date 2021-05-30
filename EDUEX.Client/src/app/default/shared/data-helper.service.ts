
export class DateHelper{

    static calculateAge(birthday: Date) { 
        var today = new Date();
        var birthDate = new Date(birthday);
        var age = today.getFullYear() - birthDate.getFullYear();
        var m = today.getMonth() - birthDate.getMonth();
        if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
            age = age - 1;
        }

        return age;
    }

    static isAlreadyPassed(date: Date | string)
    {
        var newDate = new Date(date);
        var now = new Date();
        return newDate > now;
    }
}
