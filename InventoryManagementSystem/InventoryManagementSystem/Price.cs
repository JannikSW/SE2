namespace InventoryManagementSystem
{
    internal class Price
    {
        protected int big;
        protected int small;

        internal Price(int bigPrice, int smallPrice)
        {
            this.big = bigPrice;
            this.small = smallPrice;
        }

        internal string toString()
        {
            return this.big.ToString() + "." + this.small.ToString();
        }
    }
}
