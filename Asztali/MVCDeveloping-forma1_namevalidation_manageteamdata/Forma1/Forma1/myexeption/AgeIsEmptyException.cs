using System;
using System.Runtime.Serialization;

namespace Forma1.validation
{
    [Serializable]
    public class AgeIsEmptyException : Exception
    {
        public AgeIsEmptyException(string message)
         : base(message)
        { }
    }
}