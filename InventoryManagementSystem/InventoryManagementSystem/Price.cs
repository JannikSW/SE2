using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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

        internal string infoString()
        {
            return String.Format("{0}.{1}", this.big.ToString(), this.small.ToString());
        }
    }
}
