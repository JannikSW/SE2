namespace InventoryManagementSystem.Layer_3
{
    internal class Price
    {
        protected int big;
        protected int small;

        internal Price(int bigPrice, int smallPrice)
        {
            big = bigPrice;
            small = smallPrice;
        }

        internal string infoString()
        {
            return string.Format("{0}.{1}", big.ToString(), small.ToString());
        }
    }
}
