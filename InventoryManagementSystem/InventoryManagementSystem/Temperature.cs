namespace InventoryManagementSystem
{
    internal abstract class Temperature
    {
        protected string unit = "";
        protected int min = 0;
        protected int max = 0;

        internal string infoString()
        {
            return String.Format("{0} - {1} {2}", this.min.ToString(), this.max.ToString(), this.unit);
        }
    }
}
