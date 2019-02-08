using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base() { }
        public InsufficientFundsException(string message) : base(message) { }
        public InsufficientFundsException(string message, Exception inner) : base(message, inner) { }
    }
}
