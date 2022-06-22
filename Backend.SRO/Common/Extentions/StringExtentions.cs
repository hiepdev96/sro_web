using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Extentions
{
    public static class StringExtentions
    {
        public static readonly string EmailExpression = "^(?:[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+\\.)*[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+@(?:(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!\\.)){0,61}[a-zA-Z0-9]?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!$)){0,61}[a-zA-Z0-9]?)|(?:\\[(?:(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\.){3}(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\]))$";

        public static bool IsMatchPattern(this string value, string pattern) {
            return Regex.IsMatch(value, pattern);
        }
        public static bool IsValidMobilephone(this string strPhoneNumber)
        {
            if (string.IsNullOrWhiteSpace(strPhoneNumber))
                return false;
            string patternDienThoai = @"^0([-. ]?[0-9]{1}){9,10}[-. ]?$";
            return Regex.IsMatch(strPhoneNumber,patternDienThoai);
           
        }
        public static bool IsValidEmail(this string email)
        {
            if (String.IsNullOrEmpty(email))
                return false;

            email = email.Trim();
            var result = Regex.IsMatch(email, EmailExpression,
                RegexOptions.IgnoreCase);
            return result;
        }
    }
}
