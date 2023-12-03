using System;
using System.Runtime.Serialization;

namespace A4BankExceptionGUI
{
    [Serializable]
    internal class NegativeDepositException : Exception
    {
        public NegativeDepositException()
        {
        }

        public NegativeDepositException(string message) : base(message)
        {
        }

        public NegativeDepositException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeDepositException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}