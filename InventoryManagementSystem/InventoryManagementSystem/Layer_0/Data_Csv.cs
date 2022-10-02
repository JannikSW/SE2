using InventoryManagementSystem.Layer_3;
using Microsoft.VisualBasic.FileIO;
using System.Linq.Expressions;

namespace InventoryManagementSystem
{
    class Csv : Data
    {

        internal Csv(string pathCsv)
        {
            this.path = pathCsv;
            this.dataProduct = new List<Product>();
            this.dataProductkategory = new List<Productkategory>();
            this.dataStorageplace = new List<Storage>();
            this.dataOwner = new List<Owner>();
        }

        internal override void loadData()
        {
            TextFieldParser csvReader = new TextFieldParser(this.path);

            csvReader.SetDelimiters(new string[] { "," });
            
            while (!csvReader.EndOfData)
            {
                string[] temp = csvReader.ReadFields();
                switch (temp[0])
                {
                    case "Product":
                        Product tempProduct = new Product(temp[1], this.stringToPrice(temp[2]), DateTime.Parse(temp[3]), temp[4], temp[5], temp[6]);
                        this.dataProduct.Add(tempProduct);
                        break;
                    case "Productkategory":
                        if (temp.Length >= 4)
                        {
                            Productkategory tempPerishable = new Perishable(temp[1], this.stringToTemperature(temp[2]), int.Parse(temp[3]));
                            this.dataProductkategory.Add(tempPerishable);
                        }
                        else
                        {
                            Productkategory tempUnperishable = new Unperishable(temp[1], this.stringToTemperature(temp[2]));
                            this.dataProductkategory.Add(tempUnperishable);
                        }
                        break;
                    case "Storageplace":
                        Storage tempStorageplace = new Storage(temp[1], int.Parse(temp[2]), this.stringToTemperature(temp[3]));
                        this.dataStorageplace.Add(tempStorageplace);
                        break;
                    case "Owner":
                        Owner tempOwner = new Owner(temp[1]);
                        this.dataOwner.Add(tempOwner);
                        break;
                    default:
                        break;
                }
            }
        }

        internal override string saveData()
        {
            this.dataProduct.
            this.dataProductkategory.
            this.dataStorageplace.
            this.dataOwner.

            return "";
        }
    }
}
