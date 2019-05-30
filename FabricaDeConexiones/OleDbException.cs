using System;
using System.Runtime.Serialization;

namespace _01___Fábrica_de_Conexiones
{
    [Serializable]
    internal class OleDbException : Exception
    {
        public OleDbException()
        {
        }

        public OleDbException(string message) : base(message)
        {
        }

        public OleDbException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OleDbException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}