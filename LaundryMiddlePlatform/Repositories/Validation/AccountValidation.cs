using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repositories.Validation
{
    public class AccountValidation
    {
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, pattern);
        }
        public static bool CheckString(string value, int min, int max)
        {
            if (!string.IsNullOrEmpty(value) && (min <= value.Length && value.Length <= max))
                return true;
            return false;
        }
    }
}
