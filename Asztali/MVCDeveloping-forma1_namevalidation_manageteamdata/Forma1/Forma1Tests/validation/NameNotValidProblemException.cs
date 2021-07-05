using System;
using System.Runtime.Serialization;

namespace Forma1.validation.Tests
{
    [Serializable]
    internal class NameNotValidProblemException : Exception
    {
        public NameNotValidProblemException()
        {
        }

        public NameNotValidProblemException(string message) : base(message)
        {
        }

        public NameNotValidProblemException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NameNotValidProblemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}