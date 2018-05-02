using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RomanLib.Exceptions
{
    [Serializable]
    public class RomanNumberException : Exception
    {
        public RomanNumberException()
        {
        }

        public RomanNumberException(string message) : base(message)
        {
        }

        public RomanNumberException(string message, Exception inner) : base(message, inner)
        {
        }

        protected RomanNumberException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
