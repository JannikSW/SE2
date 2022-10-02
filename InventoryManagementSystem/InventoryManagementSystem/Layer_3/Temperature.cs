namespace InventoryManagementSystem.Layer_3
{
    internal abstract class Temperature
    {
        protected string unit = "";
        protected int min = 0;
        protected int max = 0;

        internal string infoString()
        {
            return string.Format("{0} - {1} {2}", min.ToString(), max.ToString(), unit);
        }
    }
}
