using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook.Common
{
    public static class CommonFucntions
    {
        public static bool IsNumeric(this string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
