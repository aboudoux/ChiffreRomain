namespace RomanLib.Exceptions
{
    public class AddRomanNumberException : RomanNumberException
    {
        public AddRomanNumberException(string digitGauche, string digitDroit)
            : base("Le chiffre romain '" + digitGauche + "' ne peut être additionné avec '" + digitDroit + "'")
        {
            
        }
    }
}