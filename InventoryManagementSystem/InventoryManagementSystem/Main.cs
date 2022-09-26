using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Net.Http.Headers;

namespace InventoryManagementSystem
{
    public partial class Main : Form
    {
        List<Product> myProduct;
        List<Productkategory> myProductkategory;
        List<Storage> myStorage;
        List<Owner> myOwner;


        public Main()
        {
            InitializeComponent();
            this.myStorage = new List<Storage>();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addProductkategory_Click(object sender, EventArgs e)
        {

            string productkategoryName = teb_addProductkategoryName.Text;
            Temperature productkategoryTemperature = new Temperature(int.Parse(teb_addProductkategoryTemperature.Text));

            this.myProductkategory.Add(new Productkategory(productkategoryName, productkategoryTemperature));
            this.UpdateView();
        }

        private void btn_addStorageplace_Click(object sender, EventArgs e)
        {
            string storageName = teb_addStorageName.Text;
            int storageCapacity = int.Parse(teb_addStorageCapacity.Text);
            Temperature storageTemperature = new Temperature(int.Parse(teb_addStorageTemperature.Text));

            this.myStorage.Add(new Storage(storageName, storageCapacity, storageTemperature));
            this.UpdateView();
        }


        private void UpdateView()
        {
            // myProduct
            // myProduckategory

            liv_Storage.Items.Clear();
            foreach(Storage tempStorage in this.myStorage)
            liv_Storage.Items.Add(tempStorage.infoString());

            // myOwner
        }

    }
}