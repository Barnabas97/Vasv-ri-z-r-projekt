using System;
using System.Runtime.Serialization;

namespace Forma1.validation
{
    [Serializable]
    public class AgeIsLessThanMinException : Exception
    {
        public AgeIsLessThanMinException(string message)
         : base(message)
        { }
    }
}