using System.Xml;
using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem
{
    abstract class Data
    {
        internal List<Product> dataProduct;
        internal List<Productkategory> dataProductkategory;
        internal List<Storage> dataStorageplace;
        internal List<Owner> dataOwner;

        protected string path = "";

        abstract internal void loadData();

        abstract internal string saveData();

        protected Price stringToPrice(string input)
        {
            Price output;

            int indexOfPoint = input.IndexOf('.');
            string bigPrice = input.Substring(0, indexOfPoint);
            string smallPrice =  input.Substring(indexOfPoint + 1, 2);
            output = new Price(int.Parse(bigPrice), int.Parse(smallPrice));
            
            return output;
        }

        protected Temperature stringToTemperature(string input)
        {
            Temperature output;

            int indexOfMinus = input.IndexOf(" - ");
            int indexOfLastSpace = input.IndexOf(' ', indexOfMinus + 3);
            int minTemperature = int.Parse(input.Substring(0, indexOfMinus));
            int maxTemperature = int.Parse(input.Substring(indexOfMinus + 3, indexOfLastSpace - indexOfMinus - 3));
            string unitTemperature = input.Substring(indexOfLastSpace + 1, input.Length - 1 - indexOfLastSpace);

            switch (unitTemperature)
            {
                case "°C":
                    output = new Celsius(minTemperature, maxTemperature);
                    break;
                case "°F":
                    output = new Fahrenheit(minTemperature, maxTemperature);
                    break;
                case "K":
                    output = new Kelvin(minTemperature, maxTemperature);
                    break;
                default:
                    output = new Celsius(minTemperature, maxTemperature);
                    break;
            }

            return output;
        }
    }
}
