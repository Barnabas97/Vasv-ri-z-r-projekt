using System;
using System.Runtime.Serialization;

namespace Forma1.repository
{
    [Serializable]
    internal class ModelException : Exception
    {
        public ModelException()
        {

        }

        public ModelException(string message) : base(message)
        {
        }

        public ModelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}