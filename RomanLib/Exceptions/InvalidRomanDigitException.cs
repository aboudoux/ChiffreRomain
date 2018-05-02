namespace RomanLib.Exceptions
{
    public class InvalidRomanDigitException : RomanNumberException
    {
        public InvalidRomanDigitException(string digit) : 
            base("Le chiffre " + digit + " n'est pas un chiffre romain")
        {
        }
    }
}