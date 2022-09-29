using Microsoft.VisualBasic.FileIO;
using System.Linq.Expressions;

namespace InventoryManagementSystem
{
    class Csv : Data
    {

        internal Csv(string pathCsv)
        {
            this.path = pathCsv;
            this.loadData();
        }

        protected override void loadData()
        {
            TextFieldParser csvReader = new TextFieldParser(this.path);

            csvReader.SetDelimiters(new string[] { "," });
            
            while (!csvReader.EndOfData)
            {
                string[] temp = csvReader.ReadFields();
                switch (temp[0])
                {
                    case "Product":
                        //                        Product tempProduct = new Product(temp[1], Price prductPrice, DateTime storagedateProduct, Productkategory productkategoryProduct, Storageplace storageplaceProduct, Owner ownerProduct)
                        this.stringToPrice(temp[2]);
                        break;
                    case "Productkategory":
                        break;
                    case "Storageplace":
                        break;
                    case "Owner":
                        break;
                    default:
                        break;
                }
            }
        }

        protected override void saveData()
        {
            throw new NotImplementedException();
        }
    }
}
