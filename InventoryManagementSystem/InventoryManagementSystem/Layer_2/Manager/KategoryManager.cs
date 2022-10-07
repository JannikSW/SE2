using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    public class KategoryManager: IManager
    {
        List<IInventoryElement> kategoryList;

        public KategoryManager(List<IInventoryElement> kategoryList)
        {
            this.kategoryList = kategoryList;
        }

        void IManager.addElement(string[] kategoryElement)
        {
            IInventoryElement kategory;
            Temperature kategoryTemperature;

            try
            {
                kategoryTemperature = new Temperature(kategoryElement[1]);

                if (kategoryElement.Length == 3)
                {
                    kategory = new Perishable(kategoryElement[0], kategoryTemperature, int.Parse(kategoryElement[2]));
                }
                else
                {
                    kategory = new Unperishable(kategoryElement[0], kategoryTemperature);
                }

                this.kategoryList.Add(kategory);
            }
            catch(TemperatureException e)
            {
                throw new InvalidDataException(e.Message);
            }
        }

        void IManager.deleteElement(string kategoryName)
        {
            foreach (IInventoryElement kategory in this.kategoryList)
            {
                if (kategory.getElementShortInfo() == kategoryName)
                {
                    this.kategoryList.Remove(kategory);
                    break;
                }
            }
        }

        string[] IManager.infoElement()
        {
            string[] result = new string[kategoryList.Count];
            int i = 0;

            foreach (IInventoryElement kategory in kategoryList)
            {
                result[i] = kategory.getElementInfo();
                i++;
            }
            return result;
        }

        string[] IManager.infoShortElement()
        {
            string[] result = new string[kategoryList.Count];
            int i = 0;

            foreach (IInventoryElement kategory in kategoryList)
            {
                result[i] = kategory.getElementShortInfo();
                i++;
            }
            return result;
        }
    }
}
