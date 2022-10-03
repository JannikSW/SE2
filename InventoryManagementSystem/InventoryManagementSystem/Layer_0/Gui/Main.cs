using InventoryManagementSystem.Layer_1;

namespace InventoryManagementSystem
{
    public partial class Main : Form
    {
        IConverter converter;

        public Main()
        {
            InitializeComponent();

            converter = new GuiConverter();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = teb_addProductName.Text;
            guiInfo = guiInfo + ";" + teb_addProductPrice.Text;
            guiInfo = guiInfo + ";" + teb_addProductStoragedate.Text;
            guiInfo = guiInfo + ";" + cob_addProductKategory.Text;
            guiInfo = guiInfo + ";" + cob_addProductStorage.Text;
            guiInfo = guiInfo + ";" + cob_Owner.Text;

            converter.pareseInfo("Gui", "Product", "Add", guiInfo);
        }

        private void btn_delProduct_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = teb_addProductName.Text;

            converter.pareseInfo("Gui", "Product", "Del", guiInfo);
        }

        private void btn_addKategory_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = teb_addKategoryName.Text;
            guiInfo = guiInfo + ";" + teb_addKategoryTemperature.Text;
            guiInfo = guiInfo + ";" + teb_addKategoryDurability.Text;

            converter.pareseInfo("Gui", "Kategory", "Add", guiInfo);
        }

        private void btn_delKategory_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = teb_addKategoryName.Text;

            converter.pareseInfo("Gui", "Kategory", "Del", guiInfo);
        }

        private void btn_addStorage_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = teb_addStorageName.Text;
            guiInfo = guiInfo + ";" + teb_addStorageCapacity.Text;
            guiInfo = guiInfo + ";" + teb_addStorageTemperature.Text;

            converter.pareseInfo("Gui", "Storage", "Add", guiInfo);
        }

        private void btn_delStorage_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = teb_addStorageName.Text;

            converter.pareseInfo("Gui", "Storage", "Del", guiInfo);
        }

        private void btn_addOwner_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = cob_Owner.Text;

            converter.pareseInfo("Gui", "Owner", "Add", guiInfo);
        }

        private void btn_delOwner_Click(object sender, EventArgs e)
        {
            string guiInfo;

            guiInfo = cob_Owner.Text;

            converter.pareseInfo("Gui", "Owner", "Del", guiInfo);
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
//            OpenFileDialog frm_loadFile = new OpenFileDialog();
//            string filePath = "";
            
//            frm_loadFile.InitialDirectory = "C:\\Users\\Jannik\\Desktop\\Letzte\\SE2\\Testdaten";
//            frm_loadFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
//            frm_loadFile.FilterIndex = 1;
//            frm_loadFile.RestoreDirectory = true;
            
//            if (frm_loadFile.ShowDialog() == DialogResult.OK)
//            {
//                filePath = frm_loadFile.FileName;
//                if (filePath.EndsWith(".csv"))
//                {
//                    Csv myCsv = new Csv(filePath);
//                    this.myProduct = myCsv.dataProduct;
//                    this.myProductkategory= myCsv.dataProductkategory;
//                    this.myStorageplace = myCsv.dataStorageplace;
//                    this.myOwner = myCsv.dataOwner;

//                    myCsv.loadData();
//                }
//            }
//            this.UpdateView();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //  Stream myStream;
            //   string filePath = "";
            //   string csvData = "";
            //    SaveFileDialog frm_saveFile = new SaveFileDialog();

            //    frm_saveFile.InitialDirectory = "C:\\Users\\Jannik\\Desktop\\Letzte\\SE2\\Testdaten";
            //   frm_saveFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            //   frm_saveFile.FilterIndex = 1;
            //   frm_saveFile.RestoreDirectory = true;

            //      if (frm_saveFile.ShowDialog() == DialogResult.OK)
            //    {
            //    if ((myStream = frm_saveFile.OpenFile()) != null)
            //       {
            //       filePath = frm_saveFile.FileName;
            //if (filePath.EndsWith(".csv"))
            //{
            //Csv myCsv = new Csv(filePath);
            //myCsv.dataProduct = this.myProduct;
            //myCsv.dataProductkategory = this.myProductkategory;
            //myCsv.dataStorageplace = this.myStorageplace;
            //myCsv.dataOwner = this.myOwner;

            //            csvData = myCsv.saveData();

            //            myStream()

            //}
            //myStream.Close();
            //}
            //}
            //this.UpdateView();
        }


        private void UpdateView()
        {
            liv_Product.Items.Clear();
            liv_Kategory.Items.Clear();
            liv_Storage.Items.Clear();
            cob_addProductKategory.Items.Clear();
            cob_addProductStorage.Items.Clear();
            cob_Owner.Items.Clear();

            //            foreach (Product tempProduct in this.myProduct)
            //            {
            //                liv_Product.Items.Add(tempProduct.infoString());
            //            }

            //            foreach (Productkategory tempProductkategory in this.myProductkategory)
            //            {
            //                liv_Productkategory.Items.Add(tempProductkategory.infoString());
            //                cob_addProductProductkategory.Items.Add(tempProductkategory.infoSmallString());
            //            }

            //            foreach (Storage tempStorageplace in this.myStorageplace)
            //            {
            //                liv_Storageplace.Items.Add(tempStorageplace.infoString());
            //                cob_addProductStorageplace.Items.Add(tempStorageplace.infoSmallString());
            //            }

            //            foreach (Owner tempOwner in this.myOwner)
            //            {
            //                cob_Owner.Items.Add(tempOwner.infoString());
            //            }
        }


    }
}