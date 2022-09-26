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
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Productkategory = new System.Windows.Forms.Label();
            this.lbl_Storage = new System.Windows.Forms.Label();
            this.lbl_Owner = new System.Windows.Forms.Label();
            this.btn_addOwner = new System.Windows.Forms.Button();
            this.btn_delOwner = new System.Windows.Forms.Button();
            this.cb_Owner = new System.Windows.Forms.ComboBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_delProduct = new System.Windows.Forms.Button();
            this.btn_delProductkategory = new System.Windows.Forms.Button();
            this.btn_addProductkategory = new System.Windows.Forms.Button();
            this.btn_delStorage = new System.Windows.Forms.Button();
            this.btn_addStorage = new System.Windows.Forms.Button();
            this.lbl_addProductName = new System.Windows.Forms.Label();
            this.lbl_addProductPrice = new System.Windows.Forms.Label();
            this.lbl_addProductKategory = new System.Windows.Forms.Label();
            this.lbl_addProductStoragetemperature = new System.Windows.Forms.Label();
            this.teb_addProductName = new System.Windows.Forms.TextBox();
            this.teb_addProductPrice = new System.Windows.Forms.TextBox();
            this.teb_addProductProductkategory = new System.Windows.Forms.ComboBox();
            this.teb_addProductStoragetemperature = new System.Windows.Forms.ComboBox();
            this.teb_addProductkategoryName = new System.Windows.Forms.TextBox();
            this.lbl_addProductkategoryName = new System.Windows.Forms.Label();
            this.lbl_addProductkategoryTemperature = new System.Windows.Forms.Label();
            this.lbl_addStorageTemperature = new System.Windows.Forms.Label();
            this.teb_addStorageName = new System.Windows.Forms.TextBox();
            this.lbl_addStorageName = new System.Windows.Forms.Label();
            this.teb_addProductkategoryTemperature = new System.Windows.Forms.TextBox();
            this.teb_addStorageTemperature = new System.Windows.Forms.TextBox();
            this.teb_addStorageCapacity = new System.Windows.Forms.TextBox();
            this.lbl_addStorageCapacity = new System.Windows.Forms.Label();
            this.liv_Storage = new System.Windows.Forms.ListView();
            this.liv_Productkategory = new System.Windows.Forms.ListView();
            this.liv_Product = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(490, 410);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(580, 410);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(670, 410);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
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
            this.lbl_Productkategory.Location = new System.Drawing.Point(260, 10);
            this.lbl_Productkategory.Name = "lbl_Productkategory";
            this.lbl_Productkategory.Size = new System.Drawing.Size(98, 15);
            this.lbl_Productkategory.TabIndex = 4;
            this.lbl_Productkategory.Text = "Productkategory:";
            // 
            // lbl_Storage
            // 
            this.lbl_Storage.AutoSize = true;
            this.lbl_Storage.Location = new System.Drawing.Point(510, 9);
            this.lbl_Storage.Name = "lbl_Storage";
            this.lbl_Storage.Size = new System.Drawing.Size(50, 15);
            this.lbl_Storage.TabIndex = 5;
            this.lbl_Storage.Text = "Storage:";
            // 
            // lbl_Owner
            // 
            this.lbl_Owner.AutoSize = true;
            this.lbl_Owner.Location = new System.Drawing.Point(9, 413);
            this.lbl_Owner.Name = "lbl_Owner";
            this.lbl_Owner.Size = new System.Drawing.Size(45, 15);
            this.lbl_Owner.TabIndex = 6;
            this.lbl_Owner.Text = "Owner:";
            // 
            // btn_addOwner
            // 
            this.btn_addOwner.Location = new System.Drawing.Point(200, 410);
            this.btn_addOwner.Name = "btn_addOwner";
            this.btn_addOwner.Size = new System.Drawing.Size(23, 23);
            this.btn_addOwner.TabIndex = 7;
            this.btn_addOwner.Text = "+";
            this.btn_addOwner.UseVisualStyleBackColor = true;
            // 
            // btn_delOwner
            // 
            this.btn_delOwner.Location = new System.Drawing.Point(227, 410);
            this.btn_delOwner.Name = "btn_delOwner";
            this.btn_delOwner.Size = new System.Drawing.Size(23, 23);
            this.btn_delOwner.TabIndex = 8;
            this.btn_delOwner.Text = "-";
            this.btn_delOwner.UseVisualStyleBackColor = true;
            // 
            // cb_Owner
            // 
            this.cb_Owner.FormattingEnabled = true;
            this.cb_Owner.Location = new System.Drawing.Point(55, 410);
            this.cb_Owner.Name = "cb_Owner";
            this.cb_Owner.Size = new System.Drawing.Size(140, 23);
            this.cb_Owner.TabIndex = 9;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(150, 230);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(45, 25);
            this.btn_addProduct.TabIndex = 13;
            this.btn_addProduct.Text = "+";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            // 
            // btn_delProduct
            // 
            this.btn_delProduct.Location = new System.Drawing.Point(205, 230);
            this.btn_delProduct.Name = "btn_delProduct";
            this.btn_delProduct.Size = new System.Drawing.Size(45, 25);
            this.btn_delProduct.TabIndex = 14;
            this.btn_delProduct.Text = "-";
            this.btn_delProduct.UseVisualStyleBackColor = true;
            // 
            // btn_delProductkategory
            // 
            this.btn_delProductkategory.Location = new System.Drawing.Point(455, 230);
            this.btn_delProductkategory.Name = "btn_delProductkategory";
            this.btn_delProductkategory.Size = new System.Drawing.Size(45, 25);
            this.btn_delProductkategory.TabIndex = 16;
            this.btn_delProductkategory.Text = "-";
            this.btn_delProductkategory.UseVisualStyleBackColor = true;
            // 
            // btn_addProductkategory
            // 
            this.btn_addProductkategory.Location = new System.Drawing.Point(400, 230);
            this.btn_addProductkategory.Name = "btn_addProductkategory";
            this.btn_addProductkategory.Size = new System.Drawing.Size(45, 25);
            this.btn_addProductkategory.TabIndex = 15;
            this.btn_addProductkategory.Text = "+";
            this.btn_addProductkategory.UseVisualStyleBackColor = true;
            this.btn_addProductkategory.Click += new System.EventHandler(this.btn_addProductkategory_Click);
            // 
            // btn_delStorage
            // 
            this.btn_delStorage.Location = new System.Drawing.Point(705, 230);
            this.btn_delStorage.Name = "btn_delStorage";
            this.btn_delStorage.Size = new System.Drawing.Size(45, 25);
            this.btn_delStorage.TabIndex = 18;
            this.btn_delStorage.Text = "-";
            this.btn_delStorage.UseVisualStyleBackColor = true;
            // 
            // btn_addStorage
            // 
            this.btn_addStorage.Location = new System.Drawing.Point(650, 230);
            this.btn_addStorage.Name = "btn_addStorage";
            this.btn_addStorage.Size = new System.Drawing.Size(45, 25);
            this.btn_addStorage.TabIndex = 17;
            this.btn_addStorage.Text = "+";
            this.btn_addStorage.UseVisualStyleBackColor = true;
            this.btn_addStorage.Click += new System.EventHandler(this.btn_addStorageplace_Click);
            // 
            // lbl_addProductName
            // 
            this.lbl_addProductName.AutoSize = true;
            this.lbl_addProductName.Location = new System.Drawing.Point(10, 275);
            this.lbl_addProductName.Name = "lbl_addProductName";
            this.lbl_addProductName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addProductName.TabIndex = 19;
            this.lbl_addProductName.Text = "Name:";
            this.lbl_addProductName.UseWaitCursor = true;
            // 
            // lbl_addProductPrice
            // 
            this.lbl_addProductPrice.AutoSize = true;
            this.lbl_addProductPrice.Location = new System.Drawing.Point(10, 300);
            this.lbl_addProductPrice.Name = "lbl_addProductPrice";
            this.lbl_addProductPrice.Size = new System.Drawing.Size(36, 15);
            this.lbl_addProductPrice.TabIndex = 20;
            this.lbl_addProductPrice.Text = "Price:";
            this.lbl_addProductPrice.UseWaitCursor = true;
            // 
            // lbl_addProductKategory
            // 
            this.lbl_addProductKategory.AutoSize = true;
            this.lbl_addProductKategory.Location = new System.Drawing.Point(10, 325);
            this.lbl_addProductKategory.Name = "lbl_addProductKategory";
            this.lbl_addProductKategory.Size = new System.Drawing.Size(98, 15);
            this.lbl_addProductKategory.TabIndex = 21;
            this.lbl_addProductKategory.Text = "Productkategory:";
            this.lbl_addProductKategory.UseWaitCursor = true;
            // 
            // lbl_addProductStoragetemperature
            // 
            this.lbl_addProductStoragetemperature.AutoSize = true;
            this.lbl_addProductStoragetemperature.Location = new System.Drawing.Point(10, 350);
            this.lbl_addProductStoragetemperature.Name = "lbl_addProductStoragetemperature";
            this.lbl_addProductStoragetemperature.Size = new System.Drawing.Size(115, 15);
            this.lbl_addProductStoragetemperature.TabIndex = 22;
            this.lbl_addProductStoragetemperature.Text = "Storagetemperature:";
            this.lbl_addProductStoragetemperature.UseWaitCursor = true;
            // 
            // teb_addProductName
            // 
            this.teb_addProductName.Location = new System.Drawing.Point(150, 272);
            this.teb_addProductName.Name = "teb_addProductName";
            this.teb_addProductName.Size = new System.Drawing.Size(100, 23);
            this.teb_addProductName.TabIndex = 23;
            // 
            // teb_addProductPrice
            // 
            this.teb_addProductPrice.Location = new System.Drawing.Point(150, 297);
            this.teb_addProductPrice.Name = "teb_addProductPrice";
            this.teb_addProductPrice.Size = new System.Drawing.Size(100, 23);
            this.teb_addProductPrice.TabIndex = 24;
            // 
            // teb_addProductProductkategory
            // 
            this.teb_addProductProductkategory.FormattingEnabled = true;
            this.teb_addProductProductkategory.Location = new System.Drawing.Point(150, 322);
            this.teb_addProductProductkategory.Name = "teb_addProductProductkategory";
            this.teb_addProductProductkategory.Size = new System.Drawing.Size(100, 23);
            this.teb_addProductProductkategory.TabIndex = 25;
            // 
            // teb_addProductStoragetemperature
            // 
            this.teb_addProductStoragetemperature.FormattingEnabled = true;
            this.teb_addProductStoragetemperature.Location = new System.Drawing.Point(150, 347);
            this.teb_addProductStoragetemperature.Name = "teb_addProductStoragetemperature";
            this.teb_addProductStoragetemperature.Size = new System.Drawing.Size(100, 23);
            this.teb_addProductStoragetemperature.TabIndex = 26;
            // 
            // teb_addProductkategoryName
            // 
            this.teb_addProductkategoryName.Location = new System.Drawing.Point(400, 272);
            this.teb_addProductkategoryName.Name = "teb_addProductkategoryName";
            this.teb_addProductkategoryName.Size = new System.Drawing.Size(100, 23);
            this.teb_addProductkategoryName.TabIndex = 28;
            // 
            // lbl_addProductkategoryName
            // 
            this.lbl_addProductkategoryName.AutoSize = true;
            this.lbl_addProductkategoryName.Location = new System.Drawing.Point(260, 275);
            this.lbl_addProductkategoryName.Name = "lbl_addProductkategoryName";
            this.lbl_addProductkategoryName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addProductkategoryName.TabIndex = 27;
            this.lbl_addProductkategoryName.Text = "Name:";
            this.lbl_addProductkategoryName.UseWaitCursor = true;
            // 
            // lbl_addProductkategoryTemperature
            // 
            this.lbl_addProductkategoryTemperature.AutoSize = true;
            this.lbl_addProductkategoryTemperature.Location = new System.Drawing.Point(260, 300);
            this.lbl_addProductkategoryTemperature.Name = "lbl_addProductkategoryTemperature";
            this.lbl_addProductkategoryTemperature.Size = new System.Drawing.Size(76, 15);
            this.lbl_addProductkategoryTemperature.TabIndex = 29;
            this.lbl_addProductkategoryTemperature.Text = "Temperature:";
            this.lbl_addProductkategoryTemperature.UseWaitCursor = true;
            // 
            // lbl_addStorageTemperature
            // 
            this.lbl_addStorageTemperature.AutoSize = true;
            this.lbl_addStorageTemperature.Location = new System.Drawing.Point(510, 325);
            this.lbl_addStorageTemperature.Name = "lbl_addStorageTemperature";
            this.lbl_addStorageTemperature.Size = new System.Drawing.Size(76, 15);
            this.lbl_addStorageTemperature.TabIndex = 33;
            this.lbl_addStorageTemperature.Text = "Temperature:";
            this.lbl_addStorageTemperature.UseWaitCursor = true;
            // 
            // teb_addStorageName
            // 
            this.teb_addStorageName.Location = new System.Drawing.Point(650, 272);
            this.teb_addStorageName.Name = "teb_addStorageName";
            this.teb_addStorageName.Size = new System.Drawing.Size(100, 23);
            this.teb_addStorageName.TabIndex = 32;
            // 
            // lbl_addStorageName
            // 
            this.lbl_addStorageName.AutoSize = true;
            this.lbl_addStorageName.Location = new System.Drawing.Point(510, 275);
            this.lbl_addStorageName.Name = "lbl_addStorageName";
            this.lbl_addStorageName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addStorageName.TabIndex = 31;
            this.lbl_addStorageName.Text = "Name:";
            this.lbl_addStorageName.UseWaitCursor = true;
            // 
            // teb_addProductkategoryTemperature
            // 
            this.teb_addProductkategoryTemperature.Location = new System.Drawing.Point(400, 297);
            this.teb_addProductkategoryTemperature.Name = "teb_addProductkategoryTemperature";
            this.teb_addProductkategoryTemperature.Size = new System.Drawing.Size(100, 23);
            this.teb_addProductkategoryTemperature.TabIndex = 34;
            // 
            // teb_addStorageTemperature
            // 
            this.teb_addStorageTemperature.Location = new System.Drawing.Point(650, 322);
            this.teb_addStorageTemperature.Name = "teb_addStorageTemperature";
            this.teb_addStorageTemperature.Size = new System.Drawing.Size(100, 23);
            this.teb_addStorageTemperature.TabIndex = 35;
            // 
            // teb_addStorageCapacity
            // 
            this.teb_addStorageCapacity.Location = new System.Drawing.Point(650, 297);
            this.teb_addStorageCapacity.Name = "teb_addStorageCapacity";
            this.teb_addStorageCapacity.Size = new System.Drawing.Size(100, 23);
            this.teb_addStorageCapacity.TabIndex = 37;
            // 
            // lbl_addStorageCapacity
            // 
            this.lbl_addStorageCapacity.AutoSize = true;
            this.lbl_addStorageCapacity.Location = new System.Drawing.Point(510, 300);
            this.lbl_addStorageCapacity.Name = "lbl_addStorageCapacity";
            this.lbl_addStorageCapacity.Size = new System.Drawing.Size(56, 15);
            this.lbl_addStorageCapacity.TabIndex = 36;
            this.lbl_addStorageCapacity.Text = "Capacity:";
            this.lbl_addStorageCapacity.UseWaitCursor = true;
            // 
            // liv_Storage
            // 
            this.liv_Storage.Location = new System.Drawing.Point(510, 25);
            this.liv_Storage.Name = "liv_Storage";
            this.liv_Storage.Size = new System.Drawing.Size(240, 200);
            this.liv_Storage.TabIndex = 38;
            this.liv_Storage.UseCompatibleStateImageBehavior = false;
            // 
            // liv_Productkategory
            // 
            this.liv_Productkategory.Location = new System.Drawing.Point(260, 25);
            this.liv_Productkategory.Name = "liv_Productkategory";
            this.liv_Productkategory.Size = new System.Drawing.Size(240, 200);
            this.liv_Productkategory.TabIndex = 39;
            this.liv_Productkategory.UseCompatibleStateImageBehavior = false;
            // 
            // liv_Product
            // 
            this.liv_Product.Location = new System.Drawing.Point(10, 24);
            this.liv_Product.Name = "liv_Product";
            this.liv_Product.Size = new System.Drawing.Size(240, 200);
            this.liv_Product.TabIndex = 40;
            this.liv_Product.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liv_Product);
            this.Controls.Add(this.liv_Productkategory);
            this.Controls.Add(this.liv_Storage);
            this.Controls.Add(this.teb_addStorageCapacity);
            this.Controls.Add(this.lbl_addStorageCapacity);
            this.Controls.Add(this.teb_addStorageTemperature);
            this.Controls.Add(this.teb_addProductkategoryTemperature);
            this.Controls.Add(this.lbl_addStorageTemperature);
            this.Controls.Add(this.teb_addStorageName);
            this.Controls.Add(this.lbl_addStorageName);
            this.Controls.Add(this.lbl_addProductkategoryTemperature);
            this.Controls.Add(this.teb_addProductkategoryName);
            this.Controls.Add(this.lbl_addProductkategoryName);
            this.Controls.Add(this.teb_addProductStoragetemperature);
            this.Controls.Add(this.teb_addProductProductkategory);
            this.Controls.Add(this.teb_addProductPrice);
            this.Controls.Add(this.teb_addProductName);
            this.Controls.Add(this.lbl_addProductStoragetemperature);
            this.Controls.Add(this.lbl_addProductKategory);
            this.Controls.Add(this.lbl_addProductPrice);
            this.Controls.Add(this.lbl_addProductName);
            this.Controls.Add(this.btn_delStorage);
            this.Controls.Add(this.btn_addStorage);
            this.Controls.Add(this.btn_delProductkategory);
            this.Controls.Add(this.btn_addProductkategory);
            this.Controls.Add(this.btn_delProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.cb_Owner);
            this.Controls.Add(this.btn_delOwner);
            this.Controls.Add(this.btn_addOwner);
            this.Controls.Add(this.lbl_Owner);
            this.Controls.Add(this.lbl_Storage);
            this.Controls.Add(this.lbl_Productkategory);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_New);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_New;
        private Button btn_Load;
        private Button btn_Save;
        private Label lbl_Product;
        private Label lbl_Productkategory;
        private Label lbl_Storage;
        private Label lbl_Owner;
        private Button btn_addOwner;
        private Button btn_delOwner;
        private ComboBox cb_Owner;
        private Button btn_addProduct;
        private Button btn_delProduct;
        private Button btn_delProductkategory;
        private Button btn_addProductkategory;
        private Button btn_delStorage;
        private Button btn_addStorage;
        private Label lbl_addProductName;
        private Label lbl_addProductPrice;
        private Label lbl_addProductKategory;
        private Label lbl_addProductStoragetemperature;
        private TextBox teb_addProductName;
        private TextBox teb_addProductPrice;
        private ComboBox teb_addProductProductkategory;
        private ComboBox teb_addProductStoragetemperature;
        private TextBox teb_addProductkategoryName;
        private Label lbl_addProductkategoryName;
        private Label lbl_addProductkategoryTemperature;
        private Label lbl_addStorageTemperature;
        private TextBox teb_addStorageName;
        private Label lbl_addStorageName;
        private TextBox teb_addProductkategoryTemperature;
        private TextBox teb_addStorageTemperature;
        private TextBox teb_addStorageCapacity;
        private Label lbl_addStorageCapacity;
        private ListView liv_Storage;
        private ListView liv_Productkategory;
        private ListView liv_Product;
    }
}