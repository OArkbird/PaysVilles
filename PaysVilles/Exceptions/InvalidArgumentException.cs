using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace PaysVilles
{
    public class InvalidArgumentException: Exception
    {
        public InvalidArgumentException(string message) : base(message)
        {

        }
        protected InvalidArgumentException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        
        }

        public InvalidArgumentException(string message, Exception innerException) : base(message, innerException) 
        { 
        
        }

    }
}
