using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class Exceptions
    {
        public class DatabaseNotAccessibleException : Exception
        {
            public DatabaseNotAccessibleException(string message) : base(message) { }
        }

        public class DataLengthException : Exception
        {
            public DataLengthException(string message) : base(message) { }
        }
    }
}
