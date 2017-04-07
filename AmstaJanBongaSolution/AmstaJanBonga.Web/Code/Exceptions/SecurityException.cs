using System;

/// <summary>
/// Represents a security error that occurs during application execution, this class cannot be inherited.
/// </summary>
internal sealed class SecurityException : Exception
{
    #region Exception

    /// <summary>
    /// Initializes a new instance of the Portfolio.Web.SecurityException class with default properties.
    /// </summary>
    public SecurityException()
        : base()
    { }

    /// <summary>
    /// Initializes a new instance of the Portfolio.Web.SecurityException class with default properties.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public SecurityException(string message)
        : base(message)
    { }

    /// <summary>
    /// Initializes a new instance of the Portfolio.Web.SecurityException class with default properties.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public SecurityException(string message, Exception innerException)
        : base(message, innerException)
    { }

    #endregion
}