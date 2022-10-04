using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class KategoryManager: IManager
    {
        List<IInventoryElement> kategoryList;

        internal KategoryManager(List<IInventoryElement> kategoryList)
        {
            this.kategoryList = kategoryList;
        }

        void IManager.addElement(string[] kategoryElement)
        {
            IInventoryElement kategory;
            Temperature kategoryTemperature;

            kategoryTemperature = this.stringToTemperature(kategoryElement[1]);  

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

        private Temperature stringToTemperature(string input)
        {
            Temperature result;

            int indexOfMinus = input.IndexOf(" - ");
            int indexOfLastSpace = input.IndexOf(' ', indexOfMinus + 3);
            int minTemperature = int.Parse(input.Substring(0, indexOfMinus));
            int maxTemperature = int.Parse(input.Substring(indexOfMinus + 3, indexOfLastSpace - indexOfMinus - 3));
            string unitTemperature = input.Substring(indexOfLastSpace + 1, input.Length - 1 - indexOfLastSpace);

            result = new Temperature(unitTemperature, minTemperature, maxTemperature);

            return result;
        }
    }
}
