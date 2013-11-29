using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7.Exceptions
{
    class NotTriengleException : ApplicationException
    {
        public NotTriengleException()
            : base() { }

        public NotTriengleException(String message)
            : base(message) { }

        public NotTriengleException(String message, Exception innerException)
            : base(message, innerException) { }

        public NotTriengleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
