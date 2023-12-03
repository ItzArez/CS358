using System;
using System.Runtime.Serialization;

namespace A4BankExceptionGUI
{
    [Serializable]
    internal class NegativeWithdrawException : Exception
    {
        public NegativeWithdrawException()
        {
        }

        public NegativeWithdrawException(string message) : base(message)
        {
        }

        public NegativeWithdrawException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeWithdrawException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}