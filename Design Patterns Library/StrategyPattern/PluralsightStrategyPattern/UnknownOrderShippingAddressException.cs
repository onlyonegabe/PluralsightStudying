using System;
using System.Runtime.Serialization;

namespace StrategyPattern
{
    [Serializable]
    class UnknownOrderShippingAddressException : Exception
    {
        public UnknownOrderShippingAddressException()
        {
        }

        public UnknownOrderShippingAddressException(string message) : base(message)
        {
        }

        public UnknownOrderShippingAddressException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownOrderShippingAddressException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}