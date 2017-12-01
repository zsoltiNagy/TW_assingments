using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailClientGUI
{
    public class Base64Translator
    {
        public static string Base64UrlDecode(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "<strong>Message body was not returned from Google</strong>";

            string InputStr = input.Replace("-", "+").Replace("_", "/");
            return Encoding.UTF8.GetString(Convert.FromBase64String(InputStr));
        }

        public static string Base64UrlEncode(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
    }
}
