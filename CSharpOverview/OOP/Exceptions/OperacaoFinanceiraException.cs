﻿using System.Runtime.Serialization;

namespace CSharpOverview.OOP.Exceptions
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
        }

        public OperacaoFinanceiraException(string? message) : base(message)
        {
        }

        public OperacaoFinanceiraException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OperacaoFinanceiraException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
