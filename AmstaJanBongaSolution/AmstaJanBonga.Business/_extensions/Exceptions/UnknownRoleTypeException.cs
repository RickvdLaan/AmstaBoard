using System;

/// <summary>
/// The exception that is thrown when an unknown role type is detected, this class cannot be inherited.
/// </summary>
internal sealed class UnknownRoleTypeException : Exception
{
    /// <summary>
    /// Initializes a new instance of the Portfolio.Business.Security.UnknownRoleTypeException class with default properties.
    /// </summary>
    public UnknownRoleTypeException()
        : base()
    { }

    /// <summary>
    /// Initializes a new instance of the Portfolio.Business.Security.UnknownRoleTypeException class with default properties.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public UnknownRoleTypeException(string message)
        : base(message)
    { }

    /// <summary>
    /// Initializes a new instance of the Portfolio.Business.Security.UnknownRoleTypeException class with default properties.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public UnknownRoleTypeException(string message, Exception innerException)
        : base(message, innerException)
    { }
}