using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles.Exceptions
{
    public class EmptyListException:Exception
    {
        public EmptyListException(string message) : base(message)
        {

        }
        protected EmptyListException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        
        }

        public EmptyListException(string message, Exception innerException)
            : base(message, innerException) 
        { 
        
        }

    }
}
