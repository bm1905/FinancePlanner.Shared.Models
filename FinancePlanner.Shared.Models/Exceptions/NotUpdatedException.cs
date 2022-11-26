using System;
using System.Runtime.Serialization;

namespace FinancePlanner.Shared.Models.Exceptions;

[Serializable]
public class NotUpdatedException : ApplicationException
{
    public NotUpdatedException() { }

    public NotUpdatedException(Type type) : base($"{type} is missing") { }

    public NotUpdatedException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    public NotUpdatedException(string message) : base(message) { }

    public NotUpdatedException(string message, Exception innerException) : base(message, innerException) { }

    public NotUpdatedException(string message, string stackTrace) : base(message)
    {
        StackTrace = stackTrace;
    }

    public override string? StackTrace { get; }
}