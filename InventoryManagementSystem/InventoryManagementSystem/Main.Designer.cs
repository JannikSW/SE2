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
            this.lbl_Storageplace = new System.Windows.Forms.Label();
            this.lbl_Owner = new System.Windows.Forms.Label();
            this.btn_addOwner = new System.Windows.Forms.Button();
            this.btn_delOwner = new System.Windows.Forms.Button();
            this.cb_Owner = new System.Windows.Forms.ComboBox();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.dgv_Productkategory = new System.Windows.Forms.DataGridView();
            this.dgv_Storageplace = new System.Windows.Forms.DataGridView();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_delProduct = new System.Windows.Forms.Button();
            this.btn_delProductkategory = new System.Windows.Forms.Button();
            this.btn_addProductkategory = new System.Windows.Forms.Button();
            this.btn_delStorageplace = new System.Windows.Forms.Button();
            this.btn_addStorageplace = new System.Windows.Forms.Button();
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
            this.teb_addProductkategoryStoragetemperature = new System.Windows.Forms.ComboBox();
            this.lbl_addProductkategoryStoragetemperature = new System.Windows.Forms.Label();
            this.teb_addStorageplaceProductkategory = new System.Windows.Forms.ComboBox();
            this.lbl_addStorageplaceProductkategory = new System.Windows.Forms.Label();
            this.teb_addStorageplaceName = new System.Windows.Forms.TextBox();
            this.lbl_addStorageplaceName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productkategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Storageplace)).BeginInit();
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
            // lbl_Storageplace
            // 
            this.lbl_Storageplace.AutoSize = true;
            this.lbl_Storageplace.Location = new System.Drawing.Point(510, 9);
            this.lbl_Storageplace.Name = "lbl_Storageplace";
            this.lbl_Storageplace.Size = new System.Drawing.Size(78, 15);
            this.lbl_Storageplace.TabIndex = 5;
            this.lbl_Storageplace.Text = "Storageplace:";
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
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(10, 25);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowTemplate.Height = 25;
            this.dgv_Product.Size = new System.Drawing.Size(240, 200);
            this.dgv_Product.TabIndex = 10;
            // 
            // dgv_Productkategory
            // 
            this.dgv_Productkategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productkategory.Location = new System.Drawing.Point(260, 25);
            this.dgv_Productkategory.Name = "dgv_Productkategory";
            this.dgv_Productkategory.RowTemplate.Height = 25;
            this.dgv_Productkategory.Size = new System.Drawing.Size(240, 200);
            this.dgv_Productkategory.TabIndex = 11;
            // 
            // dgv_Storageplace
            // 
            this.dgv_Storageplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Storageplace.Location = new System.Drawing.Point(510, 25);
            this.dgv_Storageplace.Name = "dgv_Storageplace";
            this.dgv_Storageplace.RowTemplate.Height = 25;
            this.dgv_Storageplace.Size = new System.Drawing.Size(240, 200);
            this.dgv_Storageplace.TabIndex = 12;
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
            // 
            // btn_delStorageplace
            // 
            this.btn_delStorageplace.Location = new System.Drawing.Point(705, 230);
            this.btn_delStorageplace.Name = "btn_delStorageplace";
            this.btn_delStorageplace.Size = new System.Drawing.Size(45, 25);
            this.btn_delStorageplace.TabIndex = 18;
            this.btn_delStorageplace.Text = "-";
            this.btn_delStorageplace.UseVisualStyleBackColor = true;
            // 
            // btn_addStorageplace
            // 
            this.btn_addStorageplace.Location = new System.Drawing.Point(650, 230);
            this.btn_addStorageplace.Name = "btn_addStorageplace";
            this.btn_addStorageplace.Size = new System.Drawing.Size(45, 25);
            this.btn_addStorageplace.TabIndex = 17;
            this.btn_addStorageplace.Text = "+";
            this.btn_addStorageplace.UseVisualStyleBackColor = true;
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
            // teb_addProductkategoryStoragetemperature
            // 
            this.teb_addProductkategoryStoragetemperature.FormattingEnabled = true;
            this.teb_addProductkategoryStoragetemperature.Location = new System.Drawing.Point(400, 297);
            this.teb_addProductkategoryStoragetemperature.Name = "teb_addProductkategoryStoragetemperature";
            this.teb_addProductkategoryStoragetemperature.Size = new System.Drawing.Size(100, 23);
            this.teb_addProductkategoryStoragetemperature.TabIndex = 30;
            // 
            // lbl_addProductkategoryStoragetemperature
            // 
            this.lbl_addProductkategoryStoragetemperature.AutoSize = true;
            this.lbl_addProductkategoryStoragetemperature.Location = new System.Drawing.Point(260, 300);
            this.lbl_addProductkategoryStoragetemperature.Name = "lbl_addProductkategoryStoragetemperature";
            this.lbl_addProductkategoryStoragetemperature.Size = new System.Drawing.Size(115, 15);
            this.lbl_addProductkategoryStoragetemperature.TabIndex = 29;
            this.lbl_addProductkategoryStoragetemperature.Text = "Storagetemperature:";
            this.lbl_addProductkategoryStoragetemperature.UseWaitCursor = true;
            // 
            // teb_addStorageplaceProductkategory
            // 
            this.teb_addStorageplaceProductkategory.FormattingEnabled = true;
            this.teb_addStorageplaceProductkategory.Location = new System.Drawing.Point(650, 297);
            this.teb_addStorageplaceProductkategory.Name = "teb_addStorageplaceProductkategory";
            this.teb_addStorageplaceProductkategory.Size = new System.Drawing.Size(100, 23);
            this.teb_addStorageplaceProductkategory.TabIndex = 34;
            // 
            // lbl_addStorageplaceProductkategory
            // 
            this.lbl_addStorageplaceProductkategory.AutoSize = true;
            this.lbl_addStorageplaceProductkategory.Location = new System.Drawing.Point(510, 300);
            this.lbl_addStorageplaceProductkategory.Name = "lbl_addStorageplaceProductkategory";
            this.lbl_addStorageplaceProductkategory.Size = new System.Drawing.Size(115, 15);
            this.lbl_addStorageplaceProductkategory.TabIndex = 33;
            this.lbl_addStorageplaceProductkategory.Text = "Storagetemperature:";
            this.lbl_addStorageplaceProductkategory.UseWaitCursor = true;
            // 
            // teb_addStorageplaceName
            // 
            this.teb_addStorageplaceName.Location = new System.Drawing.Point(650, 272);
            this.teb_addStorageplaceName.Name = "teb_addStorageplaceName";
            this.teb_addStorageplaceName.Size = new System.Drawing.Size(100, 23);
            this.teb_addStorageplaceName.TabIndex = 32;
            // 
            // lbl_addStorageplaceName
            // 
            this.lbl_addStorageplaceName.AutoSize = true;
            this.lbl_addStorageplaceName.Location = new System.Drawing.Point(510, 275);
            this.lbl_addStorageplaceName.Name = "lbl_addStorageplaceName";
            this.lbl_addStorageplaceName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addStorageplaceName.TabIndex = 31;
            this.lbl_addStorageplaceName.Text = "Name:";
            this.lbl_addStorageplaceName.UseWaitCursor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teb_addStorageplaceProductkategory);
            this.Controls.Add(this.lbl_addStorageplaceProductkategory);
            this.Controls.Add(this.teb_addStorageplaceName);
            this.Controls.Add(this.lbl_addStorageplaceName);
            this.Controls.Add(this.teb_addProductkategoryStoragetemperature);
            this.Controls.Add(this.lbl_addProductkategoryStoragetemperature);
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
            this.Controls.Add(this.btn_delStorageplace);
            this.Controls.Add(this.btn_addStorageplace);
            this.Controls.Add(this.btn_delProductkategory);
            this.Controls.Add(this.btn_addProductkategory);
            this.Controls.Add(this.btn_delProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.dgv_Storageplace);
            this.Controls.Add(this.dgv_Productkategory);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.cb_Owner);
            this.Controls.Add(this.btn_delOwner);
            this.Controls.Add(this.btn_addOwner);
            this.Controls.Add(this.lbl_Owner);
            this.Controls.Add(this.lbl_Storageplace);
            this.Controls.Add(this.lbl_Productkategory);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_New);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productkategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Storageplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_New;
        private Button btn_Load;
        private Button btn_Save;
        private Label lbl_Product;
        private Label lbl_Productkategory;
        private Label lbl_Storageplace;
        private Label lbl_Owner;
        private Button btn_addOwner;
        private Button btn_delOwner;
        private ComboBox cb_Owner;
        private DataGridView dgv_Product;
        private DataGridView dgv_Productkategory;
        private DataGridView dgv_Storageplace;
        private Button btn_addProduct;
        private Button btn_delProduct;
        private Button btn_delProductkategory;
        private Button btn_addProductkategory;
        private Button btn_delStorageplace;
        private Button btn_addStorageplace;
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
        private ComboBox teb_addProductkategoryStoragetemperature;
        private Label lbl_addProductkategoryStoragetemperature;
        private ComboBox teb_addStorageplaceProductkategory;
        private Label lbl_addStorageplaceProductkategory;
        private TextBox teb_addStorageplaceName;
        private Label lbl_addStorageplaceName;
    }
}