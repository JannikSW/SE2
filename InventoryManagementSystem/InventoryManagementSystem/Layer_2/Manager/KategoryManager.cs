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

        void IManager.addElement(string[] kategoryElement)
        {
            throw new NotImplementedException();
        }

        void IManager.deleteElement(string kategoryName)
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
