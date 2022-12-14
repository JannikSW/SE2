using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    public class ProductManager : IManager
    {
        List<IInventoryElement> productList;
        List<IInventoryElement> kategoryList;
        List<IInventoryElement> storageList;
        List<IInventoryElement> ownerList;

        public ProductManager(List<IInventoryElement> productList, List<IInventoryElement> kategoryList, List<IInventoryElement> storageList, List<IInventoryElement> ownerList)
        {
            this.productList  = productList;
            this.kategoryList = kategoryList;
            this.storageList = storageList;
            this.ownerList = ownerList;
        }

        void IManager.addElement(string[] productElement)
        {
            IInventoryElement product;
            Kategory? kategory = null;
            Storage? storage = null;
            Owner? owner = null;
            Price productPrice;
            DateTime productDate;

            try
            {
                productPrice = new Price(productElement[1]);
                productDate = DateTime.Parse(productElement[2]);

                foreach (IInventoryElement tempKategory in this.kategoryList)
                {
                    if (tempKategory.getElementShortInfo() == productElement[3])
                    {
                        kategory = (Kategory)tempKategory;
                        break;
                    }
                }

                foreach (IInventoryElement tempStorage in this.storageList)
                {
                    if (tempStorage.getElementShortInfo() == productElement[4])
                    {
                        storage = (Storage)tempStorage;
                        break;
                    }
                }

                foreach (IInventoryElement tempOwner in this.ownerList)
                {
                    if (tempOwner.getElementShortInfo() == productElement[5])
                    {
                        owner = (Owner)tempOwner;
                        break;
                    }
                }

                product = new Product(productElement[0], productPrice, productDate, kategory, storage, owner);
                this.productList.Add(product);
            }
            catch (PriceException e)
            {
                throw new InvalidDataException(e.Message);
            }
        }

        void IManager.deleteElement(string productName)
        {
            foreach (IInventoryElement product in this.productList)
            {
                if (product.getElementShortInfo() == productName)
                {
                    this.productList.Remove(product);
                    break;
                }
            }
        }

        string[] IManager.infoElement()
        {
            string[] result = new string[productList.Count];
            int i = 0;

            foreach (IInventoryElement owner in productList)
            {
                result[i] = owner.getElementInfo();
                i++;
            }
            return result;
        }

        string[] IManager.infoShortElement()
        {
                string[] result = new string[productList.Count];
                int i = 0;

                foreach (IInventoryElement owner in productList)
                {
                    result[i] = owner.getElementShortInfo();
                    i++;
                }
                return result;
        }
    }
}
