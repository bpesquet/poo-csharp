using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap7_Exceptions
{
    public class ExceptionMenfin : Exception
    {
        public ExceptionMenfin(string message)
            : base("M'enfin ! " + message)
        { }
    }
}
