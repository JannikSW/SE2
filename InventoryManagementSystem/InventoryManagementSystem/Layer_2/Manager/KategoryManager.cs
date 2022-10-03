using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class KategoryManager: IManager
    {
        List<Kategory> kategoryList;

        internal KategoryManager()
        {
            this.kategoryList = new List<Kategory>();
        }

        void IManager.executeOrder(string order, string[] element)
        {
            throw new NotImplementedException();
        }

        void IManager.addElement(string[] kategoryElement)
        {
            throw new NotImplementedException();
        }

        void IManager.deleteElement(string[] kategoryElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoElement(string[] kategoryElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoShortElement(string[] kategoryElement)
        {
            throw new NotImplementedException();
        }
    }
}
