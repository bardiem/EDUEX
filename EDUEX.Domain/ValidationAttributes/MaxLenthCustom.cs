using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain.ValidationAttributes
{
    class MaxLenthCustom : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            var length = value as string;
            if (length.Length > 10 || null == length)
                return false;

            return true;
        }
    }
}
