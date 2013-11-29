using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.Exceptions
{
    class DefectiveGoodException : ApplicationException
    {
         public DefectiveGoodException()
            : base() { }

        public DefectiveGoodException(String message)
            : base(message) { }

        public DefectiveGoodException(String message, Exception innerException)
            : base(message, innerException) { }

        public DefectiveGoodException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
