using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RomanLib.Exceptions;

namespace RomanLib
{
    public class RomanConverter
    {
        private static readonly Dictionary<char, int> NumericValues = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},

            {'P', 4}, // IV
            {'Q', 9}, // IX
            {'R',40}, // XL
            {'S',90}, // XC
            {'T', 400}, // CD
            {'U', 900}, // CM
        };

        private static readonly HashSet<char> RomanSymboles = new HashSet<char> {
            'I',
            'V',
            'X',
            'L',
            'C',
            'D',
            'M'
        };
        
        public static int Convert(string romanNumber)
        {
            if( string.IsNullOrWhiteSpace( romanNumber) )
                throw new NoRomanDigitDefinedException();

            var upperNumber = romanNumber.ToUpper();
            ValidateSymboles(upperNumber);
            ValidateArrangement(upperNumber);
            var convertibleString = GetConvertibleRomanString(upperNumber);
            return ConvertRomanStringToNumber(convertibleString);

        }

        private static string GetConvertibleRomanString(string upperNumber)
        {
            return upperNumber.ToUpper()
                      .Replace("IV", "P")
                      .Replace("IX", "Q")
                      .Replace("XL", "R")
                      .Replace("XC", "S")
                      .Replace("CD", "T")
                      .Replace("CM", "U");
        }

        private static void ValidateSymboles(string romanNumber)
        {
            foreach (var symbole in romanNumber) {
                if (!RomanSymboles.Contains(symbole))
                    throw new InvalidRomanDigitException(symbole.ToString(CultureInfo.InvariantCulture));
            }
        }

        private static void ValidateArrangement(string upperNumber)
        {
            var number = upperNumber;
            if (number.Count(a => a == 'L') > 1 ||
                number.Count(a => a == 'D') > 1 ||
                number.Count(a => a == 'V') > 1 ||

                number.Contains("XXXX") ||
                number.Contains("CCCC") ||
                number.Contains("IIII") ||
                number.Contains("MMMMM")
                )
                throw new RomanNumberFormatException();
        }

        private static int ConvertRomanStringToNumber(string convertibleString)
        {
            int result = 0;
            foreach (var digit in convertibleString)
            {
                if (!NumericValues.ContainsKey(digit))
                    throw new NoRomanDigitDefinedException();
                result += NumericValues[digit];
            }
            return result;
        }
    }
}
