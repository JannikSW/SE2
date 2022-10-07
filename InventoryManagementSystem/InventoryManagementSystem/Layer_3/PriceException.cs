using System.Runtime.Serialization;

namespace InventoryManagementSystem.Layer_3
{
    [Serializable]
    internal class PriceException : Exception
    {
        public PriceException()
        {
        }

        public PriceException(string? message) : base(message)
        {
        }

        public PriceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PriceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}