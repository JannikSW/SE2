﻿namespace InventoryManagementSystem
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
            this.btn_delProductkategory = new System.Windows.Forms.Button();
            this.btn_addProductkategory = new System.Windows.Forms.Button();
            this.btn_delStorage = new System.Windows.Forms.Button();
            this.btn_addStorage = new System.Windows.Forms.Button();
            this.lbl_addProductName = new System.Windows.Forms.Label();
            this.lbl_addProductPrice = new System.Windows.Forms.Label();
            this.lbl_addProductKategory = new System.Windows.Forms.Label();
            this.lbl_addProductStorageplace = new System.Windows.Forms.Label();
            this.teb_addProductName = new System.Windows.Forms.TextBox();
            this.teb_addProductPrice = new System.Windows.Forms.TextBox();
            this.cob_addProductProductkategory = new System.Windows.Forms.ComboBox();
            this.cob_addProductStorageplace = new System.Windows.Forms.ComboBox();
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
            this.liv_Storageplace = new System.Windows.Forms.ListView();
            this.liv_Productkategory = new System.Windows.Forms.ListView();
            this.liv_Product = new System.Windows.Forms.ListView();
            this.teb_addProductkategoryDurability = new System.Windows.Forms.TextBox();
            this.lbl_addProductkategoryDurability = new System.Windows.Forms.Label();
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
            this.lbl_Productkategory.Size = new System.Drawing.Size(98, 15);
            this.lbl_Productkategory.TabIndex = 4;
            this.lbl_Productkategory.Text = "Productkategory:";
            // 
            // lbl_Storageplace
            // 
            this.lbl_Storageplace.AutoSize = true;
            this.lbl_Storageplace.Location = new System.Drawing.Point(530, 10);
            this.lbl_Storageplace.Name = "lbl_Storageplace";
            this.lbl_Storageplace.Size = new System.Drawing.Size(78, 15);
            this.lbl_Storageplace.TabIndex = 5;
            this.lbl_Storageplace.Text = "Storageplace:";
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
            // 
            // btn_delProduct
            // 
            this.btn_delProduct.Location = new System.Drawing.Point(210, 230);
            this.btn_delProduct.Name = "btn_delProduct";
            this.btn_delProduct.Size = new System.Drawing.Size(50, 25);
            this.btn_delProduct.TabIndex = 14;
            this.btn_delProduct.Text = "-";
            this.btn_delProduct.UseVisualStyleBackColor = true;
            // 
            // btn_delProductkategory
            // 
            this.btn_delProductkategory.Location = new System.Drawing.Point(470, 230);
            this.btn_delProductkategory.Name = "btn_delProductkategory";
            this.btn_delProductkategory.Size = new System.Drawing.Size(50, 25);
            this.btn_delProductkategory.TabIndex = 16;
            this.btn_delProductkategory.Text = "-";
            this.btn_delProductkategory.UseVisualStyleBackColor = true;
            // 
            // btn_addProductkategory
            // 
            this.btn_addProductkategory.Location = new System.Drawing.Point(415, 230);
            this.btn_addProductkategory.Name = "btn_addProductkategory";
            this.btn_addProductkategory.Size = new System.Drawing.Size(50, 25);
            this.btn_addProductkategory.TabIndex = 15;
            this.btn_addProductkategory.Text = "+";
            this.btn_addProductkategory.UseVisualStyleBackColor = true;
            this.btn_addProductkategory.Click += new System.EventHandler(this.btn_addProductkategory_Click);
            // 
            // btn_delStorage
            // 
            this.btn_delStorage.Location = new System.Drawing.Point(730, 230);
            this.btn_delStorage.Name = "btn_delStorage";
            this.btn_delStorage.Size = new System.Drawing.Size(50, 25);
            this.btn_delStorage.TabIndex = 18;
            this.btn_delStorage.Text = "-";
            this.btn_delStorage.UseVisualStyleBackColor = true;
            // 
            // btn_addStorage
            // 
            this.btn_addStorage.Location = new System.Drawing.Point(675, 230);
            this.btn_addStorage.Name = "btn_addStorage";
            this.btn_addStorage.Size = new System.Drawing.Size(50, 25);
            this.btn_addStorage.TabIndex = 17;
            this.btn_addStorage.Text = "+";
            this.btn_addStorage.UseVisualStyleBackColor = true;
            this.btn_addStorage.Click += new System.EventHandler(this.btn_addStorageplace_Click);
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
            this.lbl_addProductKategory.Size = new System.Drawing.Size(98, 15);
            this.lbl_addProductKategory.TabIndex = 21;
            this.lbl_addProductKategory.Text = "Productkategory:";
            this.lbl_addProductKategory.UseWaitCursor = true;
            // 
            // lbl_addProductStorageplace
            // 
            this.lbl_addProductStorageplace.AutoSize = true;
            this.lbl_addProductStorageplace.Location = new System.Drawing.Point(10, 393);
            this.lbl_addProductStorageplace.Name = "lbl_addProductStorageplace";
            this.lbl_addProductStorageplace.Size = new System.Drawing.Size(78, 15);
            this.lbl_addProductStorageplace.TabIndex = 22;
            this.lbl_addProductStorageplace.Text = "Storageplace:";
            this.lbl_addProductStorageplace.UseWaitCursor = true;
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
            // cob_addProductProductkategory
            // 
            this.cob_addProductProductkategory.FormattingEnabled = true;
            this.cob_addProductProductkategory.Location = new System.Drawing.Point(155, 360);
            this.cob_addProductProductkategory.Name = "cob_addProductProductkategory";
            this.cob_addProductProductkategory.Size = new System.Drawing.Size(105, 23);
            this.cob_addProductProductkategory.TabIndex = 25;
            // 
            // cob_addProductStorageplace
            // 
            this.cob_addProductStorageplace.FormattingEnabled = true;
            this.cob_addProductStorageplace.Location = new System.Drawing.Point(155, 390);
            this.cob_addProductStorageplace.Name = "cob_addProductStorageplace";
            this.cob_addProductStorageplace.Size = new System.Drawing.Size(105, 23);
            this.cob_addProductStorageplace.TabIndex = 26;
            // 
            // teb_addProductkategoryName
            // 
            this.teb_addProductkategoryName.Location = new System.Drawing.Point(415, 270);
            this.teb_addProductkategoryName.Name = "teb_addProductkategoryName";
            this.teb_addProductkategoryName.Size = new System.Drawing.Size(105, 23);
            this.teb_addProductkategoryName.TabIndex = 28;
            // 
            // lbl_addProductkategoryName
            // 
            this.lbl_addProductkategoryName.AutoSize = true;
            this.lbl_addProductkategoryName.Location = new System.Drawing.Point(270, 273);
            this.lbl_addProductkategoryName.Name = "lbl_addProductkategoryName";
            this.lbl_addProductkategoryName.Size = new System.Drawing.Size(42, 15);
            this.lbl_addProductkategoryName.TabIndex = 27;
            this.lbl_addProductkategoryName.Text = "Name:";
            this.lbl_addProductkategoryName.UseWaitCursor = true;
            // 
            // lbl_addProductkategoryTemperature
            // 
            this.lbl_addProductkategoryTemperature.AutoSize = true;
            this.lbl_addProductkategoryTemperature.Location = new System.Drawing.Point(270, 303);
            this.lbl_addProductkategoryTemperature.Name = "lbl_addProductkategoryTemperature";
            this.lbl_addProductkategoryTemperature.Size = new System.Drawing.Size(76, 15);
            this.lbl_addProductkategoryTemperature.TabIndex = 29;
            this.lbl_addProductkategoryTemperature.Text = "Temperature:";
            this.lbl_addProductkategoryTemperature.UseWaitCursor = true;
            // 
            // lbl_addStorageTemperature
            // 
            this.lbl_addStorageTemperature.AutoSize = true;
            this.lbl_addStorageTemperature.Location = new System.Drawing.Point(530, 333);
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
            // teb_addProductkategoryTemperature
            // 
            this.teb_addProductkategoryTemperature.Location = new System.Drawing.Point(415, 300);
            this.teb_addProductkategoryTemperature.Name = "teb_addProductkategoryTemperature";
            this.teb_addProductkategoryTemperature.Size = new System.Drawing.Size(105, 23);
            this.teb_addProductkategoryTemperature.TabIndex = 34;
            // 
            // teb_addStorageTemperature
            // 
            this.teb_addStorageTemperature.Location = new System.Drawing.Point(675, 330);
            this.teb_addStorageTemperature.Name = "teb_addStorageTemperature";
            this.teb_addStorageTemperature.Size = new System.Drawing.Size(105, 23);
            this.teb_addStorageTemperature.TabIndex = 35;
            // 
            // teb_addStorageCapacity
            // 
            this.teb_addStorageCapacity.Location = new System.Drawing.Point(675, 300);
            this.teb_addStorageCapacity.Name = "teb_addStorageCapacity";
            this.teb_addStorageCapacity.Size = new System.Drawing.Size(105, 23);
            this.teb_addStorageCapacity.TabIndex = 37;
            // 
            // lbl_addStorageCapacity
            // 
            this.lbl_addStorageCapacity.AutoSize = true;
            this.lbl_addStorageCapacity.Location = new System.Drawing.Point(530, 303);
            this.lbl_addStorageCapacity.Name = "lbl_addStorageCapacity";
            this.lbl_addStorageCapacity.Size = new System.Drawing.Size(56, 15);
            this.lbl_addStorageCapacity.TabIndex = 36;
            this.lbl_addStorageCapacity.Text = "Capacity:";
            this.lbl_addStorageCapacity.UseWaitCursor = true;
            // 
            // liv_Storageplace
            // 
            this.liv_Storageplace.Location = new System.Drawing.Point(530, 25);
            this.liv_Storageplace.Name = "liv_Storageplace";
            this.liv_Storageplace.Size = new System.Drawing.Size(250, 200);
            this.liv_Storageplace.TabIndex = 38;
            this.liv_Storageplace.UseCompatibleStateImageBehavior = false;
            // 
            // liv_Productkategory
            // 
            this.liv_Productkategory.Location = new System.Drawing.Point(270, 25);
            this.liv_Productkategory.Name = "liv_Productkategory";
            this.liv_Productkategory.Size = new System.Drawing.Size(250, 200);
            this.liv_Productkategory.TabIndex = 39;
            this.liv_Productkategory.UseCompatibleStateImageBehavior = false;
            // 
            // liv_Product
            // 
            this.liv_Product.Location = new System.Drawing.Point(10, 25);
            this.liv_Product.Name = "liv_Product";
            this.liv_Product.Size = new System.Drawing.Size(250, 200);
            this.liv_Product.TabIndex = 40;
            this.liv_Product.UseCompatibleStateImageBehavior = false;
            // 
            // teb_addProductkategoryDurability
            // 
            this.teb_addProductkategoryDurability.Location = new System.Drawing.Point(415, 330);
            this.teb_addProductkategoryDurability.Name = "teb_addProductkategoryDurability";
            this.teb_addProductkategoryDurability.Size = new System.Drawing.Size(105, 23);
            this.teb_addProductkategoryDurability.TabIndex = 42;
            // 
            // lbl_addProductkategoryDurability
            // 
            this.lbl_addProductkategoryDurability.AutoSize = true;
            this.lbl_addProductkategoryDurability.Location = new System.Drawing.Point(270, 333);
            this.lbl_addProductkategoryDurability.Name = "lbl_addProductkategoryDurability";
            this.lbl_addProductkategoryDurability.Size = new System.Drawing.Size(61, 15);
            this.lbl_addProductkategoryDurability.TabIndex = 41;
            this.lbl_addProductkategoryDurability.Text = "Durability:";
            this.lbl_addProductkategoryDurability.UseWaitCursor = true;
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
            this.Controls.Add(this.teb_addProductkategoryDurability);
            this.Controls.Add(this.lbl_addProductkategoryDurability);
            this.Controls.Add(this.liv_Product);
            this.Controls.Add(this.liv_Productkategory);
            this.Controls.Add(this.liv_Storageplace);
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
            this.Controls.Add(this.cob_addProductStorageplace);
            this.Controls.Add(this.cob_addProductProductkategory);
            this.Controls.Add(this.teb_addProductPrice);
            this.Controls.Add(this.teb_addProductName);
            this.Controls.Add(this.lbl_addProductStorageplace);
            this.Controls.Add(this.lbl_addProductKategory);
            this.Controls.Add(this.lbl_addProductPrice);
            this.Controls.Add(this.lbl_addProductName);
            this.Controls.Add(this.btn_delStorage);
            this.Controls.Add(this.btn_addStorage);
            this.Controls.Add(this.btn_delProductkategory);
            this.Controls.Add(this.btn_addProductkategory);
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
        private Button btn_delProductkategory;
        private Button btn_addProductkategory;
        private Button btn_delStorage;
        private Button btn_addStorage;
        private Label lbl_addProductName;
        private Label lbl_addProductPrice;
        private Label lbl_addProductKategory;
        private Label lbl_addProductStorageplace;
        private TextBox teb_addProductName;
        private TextBox teb_addProductPrice;
        private ComboBox cob_addProductProductkategory;
        private ComboBox cob_addProductStorageplace;
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
        private ListView liv_Storageplace;
        private ListView liv_Productkategory;
        private ListView liv_Product;
        private TextBox teb_addProductkategoryDurability;
        private Label lbl_addProductkategoryDurability;
        private TextBox teb_addProductStoragedate;
        private Label lbl_addProductStoragedate;
        private TextBox teb_addOwner;
    }
}