using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Exceptions
{
    public class OutOfStockException : Exception
    {
        public OutOfStockException() : base() { }
        public OutOfStockException(string message) : base(message) { }
        public OutOfStockException(string message, Exception inner) : base(message, inner) { }
    }
}
