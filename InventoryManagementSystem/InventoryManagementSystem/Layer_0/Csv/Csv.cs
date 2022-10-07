using InventoryManagementSystem.Layer_1;

namespace InventoryManagementSystem
{
    class Csv
    {
        IConverter converter;
        string path;

        public Csv(string pathCsv, Formatter formatter)
        {
            converter = new CsvConverter(formatter);
            this.path = pathCsv;
            this.sendInformation();
        }

        public void sendInformation()
        {
            var reader = new StreamReader(File.OpenRead(this.path));
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                string elementInfo = "";

                string elementName = values[0];
                foreach (var element in values)
                {
                    if (elementInfo != "Product" || elementInfo != "Storage" || elementInfo != "Kategory" || elementInfo != "Owner")
                    elementInfo = elementInfo + element;
                }

                converter.parseInfo("Csv", elementName, "Add", elementInfo);
            }
        }
    }
}