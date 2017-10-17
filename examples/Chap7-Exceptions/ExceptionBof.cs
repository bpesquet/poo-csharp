using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap7_Exceptions
{
    public class ExceptionBof : Exception
    {
        public ExceptionBof(string message)
            : base("Bof ! " + message)
        { }
    }
}
