using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLambdaExpression
{
    public class InvalidUserRegistrationException:Exception
    {

        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE
        }
        private ExceptionType type;
        public InvalidUserRegistrationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

