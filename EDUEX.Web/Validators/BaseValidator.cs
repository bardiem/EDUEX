using FluentValidation;
using System;

namespace EDUEX.Web.Validators
{
    public abstract class BaseValidator<T> : AbstractValidator<T>
    {
        protected virtual bool IsLessThanToday(DateTime date)
        {
            return date < DateTime.Now;
        }

        protected virtual bool IsLessThan150YearsAgo(DateTime date)
        {
            var date150Ago = DateTime.UtcNow.AddYears(-150);
            return date > date150Ago;
        }

        protected virtual bool IsValidBirthDate(DateTime date)
        {
            return IsLessThan150YearsAgo(date) && IsLessThanToday(date);
        }

        protected virtual bool IsValidBirthDate(DateTime? date)
        {
            if (!date.HasValue)
                return false;

            return IsLessThan150YearsAgo(date.Value) && IsLessThanToday(date.Value);
        }

    }
}
