using System;
using System.Runtime.Serialization;

namespace FinancePlanner.Shared.Models.Exceptions
{
    [Serializable]
    public class BadRequestException : ApplicationException
    {
        public BadRequestException() { }

        public BadRequestException(Type type) : base($"{type} is missing") { }

        public BadRequestException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public BadRequestException(string message) : base(message) { }

        public BadRequestException(string message, Exception innerException) : base(message, innerException) { }

        public BadRequestException(string message, string? stackTrace) : base(message)
        {
            StackTrace = stackTrace;
        }

        public override string? StackTrace { get; }
    }
}
