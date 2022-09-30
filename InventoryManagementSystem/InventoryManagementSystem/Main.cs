using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Net.Http.Headers;
using System.Windows.Forms;

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
            this.myOwner           = new List<Owner>();
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
            //string productkategoryName = teb_addProductkategoryName.Text;
            //Temperature productkategoryTemperature = new Temperature(int.Parse(teb_addProductkategoryTemperature.Text));
            //int productkategoryDurability = int.Parse(teb_addProductkategoryDurability.Text);

            //this.myProductkategory.Add(new Productkategory(productkategoryName, productkategoryTemperature, productkategoryDurability));
            //this.UpdateView();
        }

        private void btn_addStorageplace_Click(object sender, EventArgs e)
        {
            //string storageName = teb_addStorageName.Text;
            //int storageCapacity = int.Parse(teb_addStorageCapacity.Text);
            //Temperature storageTemperature = new Temperature(int.Parse(teb_addStorageTemperature.Text));

            //this.myStorageplace.Add(new Storageplace(storageName, storageCapacity, storageTemperature));
            //this.UpdateView();
        }

        private void UpdateView()
        {
            liv_Product.Items.Clear();
            liv_Productkategory.Items.Clear();
            liv_Storageplace.Items.Clear();
            cob_addProductProductkategory.Items.Clear();
            cob_addProductStorageplace.Items.Clear();
            cob_Owner.Items.Clear();

            foreach (Product tempProduct in this.myProduct)
            {
                liv_Productkategory.Items.Add(tempProduct.infoString());
            }

            foreach (Productkategory tempProductkategory in this.myProductkategory)
            {
                liv_Productkategory.Items.Add(tempProductkategory.infoString());
                cob_addProductProductkategory.Items.Add(tempProductkategory.infoSmallString());
            }

            foreach (Storageplace tempStorageplace in this.myStorageplace)
            {
                liv_Storageplace.Items.Add(tempStorageplace.infoString());
                cob_addProductStorageplace.Items.Add(tempStorageplace.infoSmallString());
            }
            
            foreach (Owner tempOwner in this.myOwner)
            {
                cob_Owner.Items.Add(tempOwner.infoString());
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog frm_loadFile = new OpenFileDialog();
            string filePath = "";
            
            frm_loadFile.InitialDirectory = "C:\\";
            frm_loadFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            frm_loadFile.FilterIndex = 1;
            frm_loadFile.RestoreDirectory = true;
            
            if (frm_loadFile.ShowDialog() == DialogResult.OK)
            {
                filePath = frm_loadFile.FileName;
                if (filePath.EndsWith(".csv"))
                {
                    Csv myCsv = new Csv(filePath);
                }


            }
            this.UpdateView();
        }
    }
}