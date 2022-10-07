using System.Runtime.Serialization;

namespace InventoryManagementSystem.Layer_3
{
    [Serializable]
    public class TemperatureException : Exception
    {
        public TemperatureException()
        {
        }

        public TemperatureException(string? message) : base(message)
        {
        }

        public TemperatureException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TemperatureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}