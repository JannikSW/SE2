using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class ProductManager : IManager
    {
        List<Product> productList;

        internal ProductManager()
        {
            this.productList = new List<Product>();
        }

        void IManager.addElement(string[] productElement)
        {
            throw new NotImplementedException();
        }

        void IManager.deleteElement(string productName)
        {
            throw new NotImplementedException();
        }

        string[] IManager.infoElement()
        {
            throw new NotImplementedException();
        }

        string[] IManager.infoShortElement()
        {
            throw new NotImplementedException();
        }
    }
}
