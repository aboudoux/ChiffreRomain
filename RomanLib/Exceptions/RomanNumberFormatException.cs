namespace RomanLib.Exceptions
{
    public class RomanNumberFormatException : RomanNumberException
    {
        public RomanNumberFormatException() : base("Format de nombre romain incorrect")
        {
            
        }
    }
}