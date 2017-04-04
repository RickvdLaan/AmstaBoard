using System;

/// <summary>
/// Represents a not implemented error that occurs during application execution, this class cannot be inherited.
/// </summary>
internal sealed class DefaultPageNotImplementedException : Exception
{
    #region Exception

    /// <summary>
    /// Initializes a new instance of the Portfolio.Admin.DefaultPageNotImplementedException class with default properties.
    /// </summary>
    public DefaultPageNotImplementedException()
        : base()
    { }

    /// <summary>
    /// Initializes a new instance of the Portfolio.Admin.DefaultPageNotImplementedException class with default properties.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public DefaultPageNotImplementedException(string message)
        : base(message)
    { }

    /// <summary>
    /// Initializes a new instance of the Portfolio.Admin.DefaultPageNotImplementedException class with default properties.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public DefaultPageNotImplementedException(string message, Exception innerException)
        : base(message, innerException)
    { }

    #endregion
}