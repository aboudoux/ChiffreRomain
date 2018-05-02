namespace RomanLib.Exceptions
{
    public class NoRomanDigitDefinedException : RomanNumberException
    {
        public NoRomanDigitDefinedException() :
            base("Aucun caractère correspondant à un chiffre romain n'a été défini")
        {
            
        }
    }
}