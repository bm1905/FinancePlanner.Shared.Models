using System;
using System.Runtime.Serialization;

namespace FinancePlanner.Shared.Models.Exceptions
{
    [Serializable]
    public class UnauthorizedException : ApplicationException
    {
        public UnauthorizedException() { }

        public UnauthorizedException(Type type) : base($"{type} is missing") { }

        public UnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public UnauthorizedException(string message) : base(message) { }

        public UnauthorizedException(string message, Exception innerException) : base(message, innerException) { }

        public UnauthorizedException(string message, string stackTrace) : base(message)
        {
            StackTrace = stackTrace;
        }

        public override string? StackTrace { get; }
    }
}
