using System;
using System.Runtime.Serialization;

namespace FinancePlanner.Shared.Models.Exceptions
{
    [Serializable]
    public class NotFoundException : ApplicationException
    {
        public NotFoundException() { }

        public NotFoundException(Type type) : base($"{type} is missing") { }

        public NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception innerException) : base(message, innerException) { }

        public NotFoundException(string message, string stackTrace) : base(message)
        {
            StackTrace = stackTrace;
        }

        public override string? StackTrace { get; }
    }
}