using System;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain.ValidationAttributes
{
    public class BirthDateCorrect : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var date = value as DateTime?;
            if (!date.HasValue || null == date)
                return false;

            var age = DateTime.Now.Year - date.Value.Year;
            return age < 121;
        }

    }
}
