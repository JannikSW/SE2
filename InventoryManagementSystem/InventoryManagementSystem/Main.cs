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
        List<Storageplace> myStorageplace;
        List<Owner> myOwner;


        public Main()
        {
            InitializeComponent();
            this.myProduct         = new List<Product>();
            this.myProductkategory = new List<Productkategory>();
            this.myStorageplace    = new List<Storageplace>();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            //string productName                     = teb_addProductName.Text;
            //double productPrice                    = double.Parse(teb_addProductPrice.Text);
            //Productkategory productProductkategory = teb_addProductProductkategory.Text;
            //Storageplace productStorageplace       = teb_addProductStorageplace.Text;

            //this.myProductkategory.Add(new Product(productName, productPrice, productProductkategory, productStorageplace));
            //this.UpdateView();

        }

        private void btn_addProductkategory_Click(object sender, EventArgs e)
        {
            string productkategoryName = teb_addProductkategoryName.Text;
            Temperature productkategoryTemperature = new Temperature(int.Parse(teb_addProductkategoryTemperature.Text));
            int productkategoryDurability = int.Parse(teb_addProductkategoryDurability.Text);

            this.myProductkategory.Add(new Productkategory(productkategoryName, productkategoryTemperature, productkategoryDurability));
            this.UpdateView();
        }

        private void btn_addStorageplace_Click(object sender, EventArgs e)
        {
            string storageName = teb_addStorageName.Text;
            int storageCapacity = int.Parse(teb_addStorageCapacity.Text);
            Temperature storageTemperature = new Temperature(int.Parse(teb_addStorageTemperature.Text));

            this.myStorageplace.Add(new Storageplace(storageName, storageCapacity, storageTemperature));
            this.UpdateView();
        }


        private void UpdateView()
        {
            // myProduct

            liv_Productkategory.Items.Clear();
            foreach (Productkategory tempProductkategory in this.myProductkategory)
            liv_Productkategory.Items.Add(tempProductkategory.infoString());

            liv_Storageplace.Items.Clear();
            foreach(Storageplace tempStorageplace in this.myStorageplace)
            liv_Storageplace.Items.Add(tempStorageplace.infoString());

            // myOwner
        }

    }
}