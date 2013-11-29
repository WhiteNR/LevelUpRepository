using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7.Exceptions
{
    class WrongTriengleException : ApplicationException
    {
        public WrongTriengleException()
            : base() { }

        public WrongTriengleException(String message)
            : base(message) { }

        public WrongTriengleException(String message, Exception innerException)
            : base(message, innerException) { }

        public WrongTriengleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}


