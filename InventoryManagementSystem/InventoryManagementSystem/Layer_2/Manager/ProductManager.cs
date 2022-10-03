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

        void IManager.executeOrder(string order, string[] element)
        {
            throw new NotImplementedException();
        }

        void IManager.addElement(string[] productElement)
        {
            throw new NotImplementedException();
        }

        void IManager.deleteElement(string[] productElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoElement(string[] productElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoShortElement(string[] productElement)
        {
            throw new NotImplementedException();
        }
    }
}
