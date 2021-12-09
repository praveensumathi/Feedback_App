using System;

namespace Feedback.Application.Common.Exceptions
{
    public class ApplicationSqlException : Exception
    {
        public ApplicationSqlException()
        {
        }

        public ApplicationSqlException(string message) : base(message)
        {
            
        }

        public ApplicationSqlException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
