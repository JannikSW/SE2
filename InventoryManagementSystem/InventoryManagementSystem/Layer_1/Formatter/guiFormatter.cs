using InventoryManagementSystem.Layer_2;

namespace InventoryManagementSystem.Layer_1
{
    internal class guiFormatter : IFormatter
    {
        string[] IFormatter.formatInput(string guiInput)
        {
            return guiInput.Split(';');
        }

        IFormatter.elementInfo IFormatter.formatrequest(string elementName, string elementLength)
        {
            bool length;
            if (elementLength == "True")
            {
                length = true;
            }
            else
            {
                length = false;
            }

            IFormatter.elementInfo requestInfo = new IFormatter.elementInfo { name = elementName, length = length };
            return requestInfo;
        }


    }
}