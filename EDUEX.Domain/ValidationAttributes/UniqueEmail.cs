using System;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain.ValidationAttributes
{
    public class UniqueEmail : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            var now = DateTime.Now;

            var date = value as DateTime?;
            if (!date.HasValue || null == date)
                return false;

            return now > date;
        }
    }
}
