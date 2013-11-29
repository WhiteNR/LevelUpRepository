using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.Exceptions
{
    class OutOfStockException : ApplicationException
    {
        public OutOfStockException()
            : base() { }

        public OutOfStockException(String message)
            : base(message) { }

        public OutOfStockException(String message, Exception innerException)
            : base(message, innerException) { }

        public OutOfStockException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
