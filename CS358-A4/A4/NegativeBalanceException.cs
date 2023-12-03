﻿using System;
using System.Runtime.Serialization;

namespace A4BankExceptionGUI
{
    [Serializable]
    internal class NegativeBalanceException : Exception
    {
        public NegativeBalanceException()
        {
        }

        public NegativeBalanceException(string message) : base(message)
        {
        }

        public NegativeBalanceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeBalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}