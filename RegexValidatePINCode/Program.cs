using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidatePINCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePin("123"));
            Console.ReadKey();
        }

        public static bool ValidatePin(string pin)
        {
            string value = pin.Replace(" ", "");
            string pattern = @"^\d{4}$|^\d{6}$";
            var regex = new Regex(pattern);



            return regex.IsMatch(pin) ? true : false;
        }

        public static bool ValidatePin1(string pin)
        {
            return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
        }

        public static bool ValidatePin2(string pin) =>
   (pin.Length == 4 || pin.Length == 6) && pin.All(Char.IsDigit);
    }
}
