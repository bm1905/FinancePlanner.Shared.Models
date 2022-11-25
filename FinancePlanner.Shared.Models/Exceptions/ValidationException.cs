using System;
using System.Runtime.Serialization;

namespace FinancePlanner.Shared.Models.Exceptions
{
    [Serializable]
    public class ValidationException : ApplicationException
    {
        public ValidationException() { }

        public ValidationException(Type type) : base($"{type} is missing") { }

        public ValidationException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public ValidationException(string message) : base(message) { }

        public ValidationException(string message, Exception innerException) : base(message, innerException) { }

        public ValidationException(string message, string stackTrace) : base(message)
        {
            StackTrace = stackTrace;
        }

        public override string? StackTrace { get; }
    }
}
