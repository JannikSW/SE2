using System.Linq.Expressions;


namespace InventoryManagementSystem.Layer_3
{
    public class Price
    {
        protected int big;
        protected int small;

        public Price(string priceString)
        {
            try
            {
                int indexOfPoint = priceString.IndexOf('.');
                string bigPrice = priceString.Substring(0, indexOfPoint);
                string smallPrice = priceString.Substring(indexOfPoint + 1, 2);

                this.big = int.Parse(bigPrice);
                this.small = int.Parse(smallPrice);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new PriceException(
                    "priceString is out of range", e);
            }
            catch (FormatException e)
            {
                throw new PriceException(
                    "priceString is not the correct format", e);

            }
        }

        public virtual string infoString()
        {
            return string.Format("{0}.{1}", big.ToString(), small.ToString());
        }
    }
}
