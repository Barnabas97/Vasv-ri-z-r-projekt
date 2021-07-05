using System;
using System.Runtime.Serialization;

namespace Forma1.validation
{
    [Serializable]
    public class IsDigitExceptionExceptio : Exception
    {
        public IsDigitExceptionExceptio(string message)
         : base(message)
        { }
    }
}