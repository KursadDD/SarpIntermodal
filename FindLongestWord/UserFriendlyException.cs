﻿using System.Runtime.Serialization;

[Serializable]
internal class UserFriendlyException : Exception
{
    public UserFriendlyException()
    {
    }

    public UserFriendlyException(string? message) : base(message)
    {
    }

    public UserFriendlyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected UserFriendlyException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}