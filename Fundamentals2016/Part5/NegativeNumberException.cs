﻿using System;

public class NegativeNumberException : Exception
{
    /// <summary>
    /// Just create the exception
    /// </summary>
    public NegativeNumberException()
      : base()
    {
    }

    /// <summary>
    /// Create the exception with description
    /// </summary>
    /// <param name="message">Exception description</param>
    public NegativeNumberException(string message)
      : base(message)
    {
    }
}
