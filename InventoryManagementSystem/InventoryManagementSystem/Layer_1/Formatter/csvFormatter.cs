using InventoryManagementSystem.Layer_2;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace InventoryManagementSystem.Layer_1
{
    internal class csvFormatter : IFormatter
    {
        string[] IFormatter.formatInput(string csvInput)
        {
            return csvInput.Split(',');
        }

        IFormatter.elementInfo IFormatter.formatrequest(string elementName, string elementLenght)
        {
            bool length;
            if (elementLenght == "True")
            {
                length = true;
            }
            else
            {
                length = false;
            }

            IFormatter.elementInfo requestInfo = new IFormatter.elementInfo{name = elementName, length = length};
            return requestInfo;
        }
    }
}