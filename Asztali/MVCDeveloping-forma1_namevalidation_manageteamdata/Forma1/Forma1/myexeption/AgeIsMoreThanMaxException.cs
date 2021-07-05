using System;
using System.Runtime.Serialization;

namespace Forma1.validation
{
    [Serializable]
    public class AgeIsMoreThanMaxException : Exception
    {
        public AgeIsMoreThanMaxException(string message)
         : base(message)
        { }
    }
}