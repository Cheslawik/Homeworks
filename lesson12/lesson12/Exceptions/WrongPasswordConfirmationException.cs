using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12.Exceptions
{
    internal class WrongPasswordConfirmationException : Exception
    {
        public WrongPasswordConfirmationException() { }
        public WrongPasswordConfirmationException(string message) : base(message) { }
    }
}
