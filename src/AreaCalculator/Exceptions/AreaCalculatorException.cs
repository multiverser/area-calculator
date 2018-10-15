using System;
using System.Runtime.Serialization;

namespace AreaCalculator.Exceptions
{
    [Serializable]
    public class AreaCalculatorException : Exception
    {
        public AreaCalculatorException(string message) 
            : base(message)
        {
        }

        public AreaCalculatorException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected AreaCalculatorException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
