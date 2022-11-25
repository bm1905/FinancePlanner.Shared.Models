using System;
using System.Runtime.Serialization;

namespace FinancePlanner.Shared.Models.Exceptions
{
    [Serializable]
    public class ApiErrorException : ApplicationException
    {
        public ApiErrorException() { }

        public ApiErrorException(Type type) : base($"{type} is missing") { }

        public ApiErrorException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public ApiErrorException(string message) : base(message) { }

        public ApiErrorException(string message, Exception innerException) : base(message, innerException) { }

        public ApiErrorException(string message, string stackTrace) : base(message)
        {
            StackTrace = stackTrace;
        }

        public override string? StackTrace { get; }
    }
}
