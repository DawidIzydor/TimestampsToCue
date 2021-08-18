using System;

namespace TimeStampsToCueAbstractions
{
    public class TimestampFormatException : ArgumentException
    {
        public TimestampFormatException(string message, string paramName) : base(message, paramName)
        {

        }
    }
}