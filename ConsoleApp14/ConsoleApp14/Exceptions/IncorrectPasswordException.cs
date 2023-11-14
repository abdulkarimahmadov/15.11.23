using System;

public class IncorrectPasswordException : Exception
{
    public IncorrectPasswordException(string message) : base(message)
    {
    }
}
