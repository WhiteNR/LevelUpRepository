using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.Exceptions
{
    class IsExpiredException : ApplicationException
    {
        public IsExpiredException()
            : base() { }

        public IsExpiredException(String message)
            : base(message) { }

        public IsExpiredException(String message, Exception innerException)
            : base(message, innerException) { }

        public IsExpiredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
