namespace InventoryManagementSystem
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Productkategory = new System.Windows.Forms.Label();
            this.lbl_Storageplace = new System.Windows.Forms.Label();
            this.lbl_Owner = new System.Windows.Forms.Label();
            this.btn_addOwner = new System.Windows.Forms.Button();
            this.btn_delOwner = new System.Windows.Forms.Button();
            this.cob_Owner = new System.Windows.Forms.ComboBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_delProduct = new System.Windows.Forms.Button();
            this.btn_delKategory = new System.Windows.Forms.Button();
            this.btn_addKategory = new System.Windows.Forms.Button();
            this.btn_delStorage = new System.Windows.Forms.Button();
            this.btn_addStorage = new System.Windows.Forms.Button();
            this.lbl_addProductName = new System.Windows.Forms.Label();
            this.lbl_addProductPrice = new System.Windows.Forms.Label();
            this.lbl_addProductKategory = new System.Windows.Forms.Label();
            this.lbl_addProductStorage = new System.Windows.Forms.Label();
            this.teb_addProductName = new System.Windows.Forms.TextBox();
            this.teb_addProductPrice = new System.Windows.Forms.TextBox();
            this.cob_addProductKategory = new System.Windows.Forms.ComboBox();
            this.cob_addProductStorage = new System.Windows.Forms.ComboBox();
            this.teb_addKategoryName = new System.Windows.Forms.TextBox();
            this.lbl_addKategoryName = new System.Windows.Forms.Label();
            this.lbl_addKategoryTemperature = new System.Windows.Forms.Label();
            this.lbl_addStorageTemperature = new System.Windows.Forms.Label();
            this.teb_addStorageName = new System.Windows.Forms.TextBox();
            this.lbl_addStorageName = new System.Windows.Forms.Label();
            this.teb_addKategoryTemperature = new System.Windows.Forms.TextBox();
            this.teb_addStorageTemperature = new System.Windows.Forms.TextBox();
            this.liv_Storage = new System.Windows.Forms.ListView();
            this.liv_Kategory = new System.Windows.Forms.ListView();
            this.liv_Product = new System.Windows.Forms.ListView();
            this.teb_addKategoryDurability = new System.Windows.Forms.TextBox();
            this.lbl_addKategoryDurability = new System.Windows.Forms.Label();
            this.teb_addProductStoragedate = new System.Windows.Forms.TextBox();
            this.lbl_addProductStoragedate = new System.Windows.Forms.Label();
            this.teb_addOwner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(625, 420);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(705, 420);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Location = new System.Drawing.Point(10, 10);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(52, 15);
            this.lbl_Product.TabIndex = 3;
            this.lbl_Product.Text = "Product:";
            this.lbl_Product.UseWaitCursor = true;
            // 
            // lbl_Productkategory
            // 
            this.lbl_Productkategory.AutoSize = true;
            this.lbl_Productkategory.Location = new System.Drawing.Point(270, 10);
            this.lbl_Productkategory.Name = "lbl_Productkategory";
            this.lbl_Productkategory.Size = new System.Drawing.Size(57, 15);
            this.lbl_Productkategory.TabIndex = 4;
            this.lbl_Productkategory.Text = "Kategory:";
            // 
            // lbl_Storageplace
            // 
            this.lbl_Storageplace.AutoSize = true;
            this.lbl_Storageplace.Location = new System.Drawing.Point(530, 10);
            this.lbl_Storageplace.Name = "lbl_Storageplace";
            this.lbl_Storageplace.Size = new System.Drawing.Size(50, 15);
            this.lbl_Storageplace.TabIndex = 5;
            this.lbl_Storageplace.Text = "Storage:";
            // 
            // lbl_Owner
            // 
            this.lbl_Owner.AutoSize = true;
            this.lbl_Owner.Location = new System.Drawing.Point(10, 423);
            this.lbl_Owner.Name = "lbl_Owner";
            this.lbl_Owner.Size = new System.Drawing.Size(45, 15);
            this.lbl_Owner.TabIndex = 6;
            this.lbl_Owner.Text = "Owner:";
            // 
            // btn_addOwner
            // 
            this.btn_addOwner.Location = new System.Drawing.Point(270, 420);
            this.btn_addOwner.Name = "btn_addOwner";
            this.btn_addOwner.Size = new System.Drawing.Size(50, 23);
            this.btn_addOwner.TabIndex = 7;
            this.btn_addOwner.Text = "+";
            this.btn_addOwner.UseVisualStyleBackColor = true;
            this.btn_addOwner.Click += new System.EventHandler(this.btn_addOwner_Click);
            // 
            // btn_delOwner
            // 
            this.btn_delOwner.Location = new System.Drawing.Point(325, 420);
            this.btn_delOwner.Name = "btn_delOwner";
            this.btn_delOwner.Size = new System.Drawing.Size(50, 23);
            this.btn_delOwner.TabIndex = 8;
            this.btn_delOwner.Text = "-";
            this.btn_delOwner.UseVisualStyleBackColor = true;
            this.btn_delOwner.Click += new System.EventHandler(this.btn_delOwner_Click);
            // 
            // cob_Owner
            // 
            this.cob_Owner.FormattingEnabled = true;
            this.cob_Owner.Location = new System.Drawing.Point(155, 420);
            this.cob_Owner.Name = "cob_Owner";
            this.cob_Owner.Size = new System.Drawing.Size(105, 23);
            this.cob_Owner.TabIndex = 9;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(155, 230);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(50, 25);
            this.btn_addProduct.TabIndex = 13;
            this.btn_addProduct.Text = "+";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_delProduct
            // 
            this.btn_delProduct.Location = new System.Drawing.Point(210, 230);
            this.btn_delProduct.Name = "btn_delProduct";
            this.btn_delProduct.Size = new System.Drawing.Size(50, 25);
            this.btn_delProduct.TabIndex = 14;
            this.btn_delProduct.Text = "-";
            this.btn_delProduct.UseVisualStyleBackColor = true;
            this.btn_delProduct.Click += new System.EventHandler(this.btn_delProduct_Click);
            // 
            // btn_delKategory
            // 
            this.btn_delKategory.Location = new System.Drawing.Point(470, 230);
            this.btn_delKategory.Name = "btn_delKategory";
            this.btn_delKategory.Size = new System.Drawing.Size(50, 25);
            this.btn_delKategory.TabIndex = 16;
            this.btn_delKategory.Text = "-";
            this.btn_delKategory.UseVisualStyleBackColor = true;
            this.btn_delKategory.Click += new System.EventHandler(this.btn_delKategory_Click);
            // 
            // btn_addKategory
            // 
            this.btn_addKategory.Location = new System.Drawing.Point(415, 230);
            this.btn_addKategory.Name = "btn_addKategory";
            this.btn_addKategory.Size = new System.Drawing.Size(50, 25);
            this.btn_addKategory.TabIndex = 15;
            this.btn_addKategory.Text = "+";
            this.btn_addKategory.UseVisualStyleBackColor = true;
            this.btn_addKategory.Click += new System.EventHandler(this.btn_addKategory_Click);
            // 
            // btn_delStorage
            // 
            this.btn_delStorage.Location = new System.Drawing.Point(730, 230);
            this.btn_delStorage.Name = "btn_delStorage";
            this.btn_delStorage.Size = new System.Drawing.Size(50, 25);
            this.btn_delStorage.TabIndex = 18;
            this.btn_delStorage.Text = "-";
            this.btn_delStorage.UseVisualStyleBackColor = true;
            this.btn_delStorage.Click += new System.EventHandler(this.btn_delStorage_Click);
            // 
            // btn_addStorage
            // 
            this.btn_addStorage.Location = new System.Drawing.Point(675, 230);
            this.btn_addStorage.Name = "btn_addStorage";
            this.btn_addStorage.Size = new System.Drawing.Size(50, 25);
            this.btn_addStorage.TabIndex = 17;
            this.btn_addStorage.Text = "+";
            this.btn_addStorage.UseVisualStyleBackColor = true;
            this.btn_addStorage.Click += new System.EventHandler(this.btn_addStorage_Click);
            // 
            // lbl_addProductName
            // 
            this.lbl_addProductName.AutoSize = true;
            this.lbl_addProductName.Location = new System.Drawing.Point(10, 273);
            this.lbl_addProductName.Name = "lbl_addProductName";
            this.lbl_addProductName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addProductName.TabIndex = 19;
            this.lbl_addProductName.Text = "Name:";
            this.lbl_addProductName.UseWaitCursor = true;
            // 
            // lbl_addProductPrice
            // 
            this.lbl_addProductPrice.AutoSize = true;
            this.lbl_addProductPrice.Location = new System.Drawing.Point(10, 303);
            this.lbl_addProductPrice.Name = "lbl_addProductPrice";
            this.lbl_addProductPrice.Size = new System.Drawing.Size(36, 15);
            this.lbl_addProductPrice.TabIndex = 20;
            this.lbl_addProductPrice.Text = "Price:";
            this.lbl_addProductPrice.UseWaitCursor = true;
            // 
            // lbl_addProductKategory
            // 
            this.lbl_addProductKategory.AutoSize = true;
            this.lbl_addProductKategory.Location = new System.Drawing.Point(10, 363);
            this.lbl_addProductKategory.Name = "lbl_addProductKategory";
            this.lbl_addProductKategory.Size = new System.Drawing.Size(57, 15);
            this.lbl_addProductKategory.TabIndex = 21;
            this.lbl_addProductKategory.Text = "Kategory:";
            this.lbl_addProductKategory.UseWaitCursor = true;
            // 
            // lbl_addProductStorage
            // 
            this.lbl_addProductStorage.AutoSize = true;
            this.lbl_addProductStorage.Location = new System.Drawing.Point(10, 393);
            this.lbl_addProductStorage.Name = "lbl_addProductStorage";
            this.lbl_addProductStorage.Size = new System.Drawing.Size(50, 15);
            this.lbl_addProductStorage.TabIndex = 22;
            this.lbl_addProductStorage.Text = "Storage:";
            this.lbl_addProductStorage.UseWaitCursor = true;
            // 
            // teb_addProductName
            // 
            this.teb_addProductName.Location = new System.Drawing.Point(155, 270);
            this.teb_addProductName.Name = "teb_addProductName";
            this.teb_addProductName.Size = new System.Drawing.Size(105, 23);
            this.teb_addProductName.TabIndex = 23;
            // 
            // teb_addProductPrice
            // 
            this.teb_addProductPrice.Location = new System.Drawing.Point(155, 300);
            this.teb_addProductPrice.Name = "teb_addProductPrice";
            this.teb_addProductPrice.Size = new System.Drawing.Size(105, 23);
            this.teb_addProductPrice.TabIndex = 24;
            // 
            // cob_addProductKategory
            // 
            this.cob_addProductKategory.FormattingEnabled = true;
            this.cob_addProductKategory.Location = new System.Drawing.Point(155, 360);
            this.cob_addProductKategory.Name = "cob_addProductKategory";
            this.cob_addProductKategory.Size = new System.Drawing.Size(105, 23);
            this.cob_addProductKategory.TabIndex = 25;
            // 
            // cob_addProductStorage
            // 
            this.cob_addProductStorage.FormattingEnabled = true;
            this.cob_addProductStorage.Location = new System.Drawing.Point(155, 390);
            this.cob_addProductStorage.Name = "cob_addProductStorage";
            this.cob_addProductStorage.Size = new System.Drawing.Size(105, 23);
            this.cob_addProductStorage.TabIndex = 26;
            // 
            // teb_addKategoryName
            // 
            this.teb_addKategoryName.Location = new System.Drawing.Point(415, 270);
            this.teb_addKategoryName.Name = "teb_addKategoryName";
            this.teb_addKategoryName.Size = new System.Drawing.Size(105, 23);
            this.teb_addKategoryName.TabIndex = 28;
            // 
            // lbl_addKategoryName
            // 
            this.lbl_addKategoryName.AutoSize = true;
            this.lbl_addKategoryName.Location = new System.Drawing.Point(270, 273);
            this.lbl_addKategoryName.Name = "lbl_addKategoryName";
            this.lbl_addKategoryName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addKategoryName.TabIndex = 27;
            this.lbl_addKategoryName.Text = "Name:";
            this.lbl_addKategoryName.UseWaitCursor = true;
            // 
            // lbl_addKategoryTemperature
            // 
            this.lbl_addKategoryTemperature.AutoSize = true;
            this.lbl_addKategoryTemperature.Location = new System.Drawing.Point(270, 303);
            this.lbl_addKategoryTemperature.Name = "lbl_addKategoryTemperature";
            this.lbl_addKategoryTemperature.Size = new System.Drawing.Size(76, 15);
            this.lbl_addKategoryTemperature.TabIndex = 29;
            this.lbl_addKategoryTemperature.Text = "Temperature:";
            this.lbl_addKategoryTemperature.UseWaitCursor = true;
            // 
            // lbl_addStorageTemperature
            // 
            this.lbl_addStorageTemperature.AutoSize = true;
            this.lbl_addStorageTemperature.Location = new System.Drawing.Point(530, 303);
            this.lbl_addStorageTemperature.Name = "lbl_addStorageTemperature";
            this.lbl_addStorageTemperature.Size = new System.Drawing.Size(76, 15);
            this.lbl_addStorageTemperature.TabIndex = 33;
            this.lbl_addStorageTemperature.Text = "Temperature:";
            this.lbl_addStorageTemperature.UseWaitCursor = true;
            // 
            // teb_addStorageName
            // 
            this.teb_addStorageName.Location = new System.Drawing.Point(675, 270);
            this.teb_addStorageName.Name = "teb_addStorageName";
            this.teb_addStorageName.Size = new System.Drawing.Size(105, 23);
            this.teb_addStorageName.TabIndex = 32;
            // 
            // lbl_addStorageName
            // 
            this.lbl_addStorageName.AutoSize = true;
            this.lbl_addStorageName.Location = new System.Drawing.Point(530, 273);
            this.lbl_addStorageName.Name = "lbl_addStorageName";
            this.lbl_addStorageName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addStorageName.TabIndex = 31;
            this.lbl_addStorageName.Text = "Name:";
            this.lbl_addStorageName.UseWaitCursor = true;
            // 
            // teb_addKategoryTemperature
            // 
            this.teb_addKategoryTemperature.Location = new System.Drawing.Point(415, 300);
            this.teb_addKategoryTemperature.Name = "teb_addKategoryTemperature";
            this.teb_addKategoryTemperature.Size = new System.Drawing.Size(105, 23);
            this.teb_addKategoryTemperature.TabIndex = 34;
            // 
            // teb_addStorageTemperature
            // 
            this.teb_addStorageTemperature.Location = new System.Drawing.Point(675, 300);
            this.teb_addStorageTemperature.Name = "teb_addStorageTemperature";
            this.teb_addStorageTemperature.Size = new System.Drawing.Size(105, 23);
            this.teb_addStorageTemperature.TabIndex = 35;
            // 
            // liv_Storage
            // 
            this.liv_Storage.Location = new System.Drawing.Point(530, 25);
            this.liv_Storage.Name = "liv_Storage";
            this.liv_Storage.Size = new System.Drawing.Size(250, 200);
            this.liv_Storage.TabIndex = 38;
            this.liv_Storage.UseCompatibleStateImageBehavior = false;
            // 
            // liv_Kategory
            // 
            this.liv_Kategory.Location = new System.Drawing.Point(270, 25);
            this.liv_Kategory.Name = "liv_Kategory";
            this.liv_Kategory.Size = new System.Drawing.Size(250, 200);
            this.liv_Kategory.TabIndex = 39;
            this.liv_Kategory.UseCompatibleStateImageBehavior = false;
            // 
            // liv_Product
            // 
            this.liv_Product.Location = new System.Drawing.Point(10, 25);
            this.liv_Product.Name = "liv_Product";
            this.liv_Product.Size = new System.Drawing.Size(250, 200);
            this.liv_Product.TabIndex = 40;
            this.liv_Product.UseCompatibleStateImageBehavior = false;
            // 
            // teb_addKategoryDurability
            // 
            this.teb_addKategoryDurability.Location = new System.Drawing.Point(415, 330);
            this.teb_addKategoryDurability.Name = "teb_addKategoryDurability";
            this.teb_addKategoryDurability.Size = new System.Drawing.Size(105, 23);
            this.teb_addKategoryDurability.TabIndex = 42;
            // 
            // lbl_addKategoryDurability
            // 
            this.lbl_addKategoryDurability.AutoSize = true;
            this.lbl_addKategoryDurability.Location = new System.Drawing.Point(270, 333);
            this.lbl_addKategoryDurability.Name = "lbl_addKategoryDurability";
            this.lbl_addKategoryDurability.Size = new System.Drawing.Size(61, 15);
            this.lbl_addKategoryDurability.TabIndex = 41;
            this.lbl_addKategoryDurability.Text = "Durability:";
            this.lbl_addKategoryDurability.UseWaitCursor = true;
            // 
            // teb_addProductStoragedate
            // 
            this.teb_addProductStoragedate.Location = new System.Drawing.Point(155, 330);
            this.teb_addProductStoragedate.Name = "teb_addProductStoragedate";
            this.teb_addProductStoragedate.Size = new System.Drawing.Size(105, 23);
            this.teb_addProductStoragedate.TabIndex = 43;
            // 
            // lbl_addProductStoragedate
            // 
            this.lbl_addProductStoragedate.AutoSize = true;
            this.lbl_addProductStoragedate.Location = new System.Drawing.Point(10, 333);
            this.lbl_addProductStoragedate.Name = "lbl_addProductStoragedate";
            this.lbl_addProductStoragedate.Size = new System.Drawing.Size(73, 15);
            this.lbl_addProductStoragedate.TabIndex = 44;
            this.lbl_addProductStoragedate.Text = "Storagedate:";
            this.lbl_addProductStoragedate.UseWaitCursor = true;
            // 
            // teb_addOwner
            // 
            this.teb_addOwner.Location = new System.Drawing.Point(415, 420);
            this.teb_addOwner.Name = "teb_addOwner";
            this.teb_addOwner.Size = new System.Drawing.Size(105, 23);
            this.teb_addOwner.TabIndex = 45;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.teb_addOwner);
            this.Controls.Add(this.lbl_addProductStoragedate);
            this.Controls.Add(this.teb_addProductStoragedate);
            this.Controls.Add(this.teb_addKategoryDurability);
            this.Controls.Add(this.lbl_addKategoryDurability);
            this.Controls.Add(this.liv_Product);
            this.Controls.Add(this.liv_Kategory);
            this.Controls.Add(this.liv_Storage);
            this.Controls.Add(this.teb_addStorageTemperature);
            this.Controls.Add(this.teb_addKategoryTemperature);
            this.Controls.Add(this.lbl_addStorageTemperature);
            this.Controls.Add(this.teb_addStorageName);
            this.Controls.Add(this.lbl_addStorageName);
            this.Controls.Add(this.lbl_addKategoryTemperature);
            this.Controls.Add(this.teb_addKategoryName);
            this.Controls.Add(this.lbl_addKategoryName);
            this.Controls.Add(this.cob_addProductStorage);
            this.Controls.Add(this.cob_addProductKategory);
            this.Controls.Add(this.teb_addProductPrice);
            this.Controls.Add(this.teb_addProductName);
            this.Controls.Add(this.lbl_addProductStorage);
            this.Controls.Add(this.lbl_addProductKategory);
            this.Controls.Add(this.lbl_addProductPrice);
            this.Controls.Add(this.lbl_addProductName);
            this.Controls.Add(this.btn_delStorage);
            this.Controls.Add(this.btn_addStorage);
            this.Controls.Add(this.btn_delKategory);
            this.Controls.Add(this.btn_addKategory);
            this.Controls.Add(this.btn_delProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.cob_Owner);
            this.Controls.Add(this.btn_delOwner);
            this.Controls.Add(this.btn_addOwner);
            this.Controls.Add(this.lbl_Owner);
            this.Controls.Add(this.lbl_Storageplace);
            this.Controls.Add(this.lbl_Productkategory);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Load;
        private Button btn_Save;
        private Label lbl_Product;
        private Label lbl_Productkategory;
        private Label lbl_Storageplace;
        private Label lbl_Owner;
        private Button btn_addOwner;
        private Button btn_delOwner;
        private ComboBox cob_Owner;
        private Button btn_addProduct;
        private Button btn_delProduct;
        private Button btn_delKategory;
        private Button btn_addKategory;
        private Button btn_delStorage;
        private Button btn_addStorage;
        private Label lbl_addProductName;
        private Label lbl_addProductPrice;
        private Label lbl_addProductKategory;
        private Label lbl_addProductStorage;
        private TextBox teb_addProductName;
        private TextBox teb_addProductPrice;
        private ComboBox cob_addProductKategory;
        private ComboBox cob_addProductStorage;
        private TextBox teb_addKategoryName;
        private Label lbl_addKategoryName;
        private Label lbl_addKategoryTemperature;
        private Label lbl_addStorageTemperature;
        private TextBox teb_addStorageName;
        private Label lbl_addStorageName;
        private TextBox teb_addKategoryTemperature;
        private TextBox teb_addStorageTemperature;
        private ListView liv_Storage;
        private ListView liv_Kategory;
        private ListView liv_Product;
        private TextBox teb_addKategoryDurability;
        private Label lbl_addKategoryDurability;
        private TextBox teb_addProductStoragedate;
        private Label lbl_addProductStoragedate;
        private TextBox teb_addOwner;
    }
}