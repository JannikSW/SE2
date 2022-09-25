namespace InventoryManagementSystem
{
    partial class Form1
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
            this.btn_addOwner.Location = new System.Drawing.Point(210, 410);
            this.btn_addOwner.Name = "btn_addOwner";
            this.btn_addOwner.Size = new System.Drawing.Size(23, 23);
            this.btn_addOwner.TabIndex = 7;
            this.btn_addOwner.Text = "+";
            this.btn_addOwner.UseVisualStyleBackColor = true;
            // 
            // btn_delOwner
            // 
            this.btn_delOwner.Location = new System.Drawing.Point(240, 410);
            this.btn_delOwner.Name = "btn_delOwner";
            this.btn_delOwner.Size = new System.Drawing.Size(23, 23);
            this.btn_delOwner.TabIndex = 8;
            this.btn_delOwner.Text = "-";
            this.btn_delOwner.UseVisualStyleBackColor = true;
            // 
            // cb_Owner
            // 
            this.cb_Owner.FormattingEnabled = true;
            this.cb_Owner.Location = new System.Drawing.Point(60, 410);
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
            this.btn_addProduct.Location = new System.Drawing.Point(140, 230);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(50, 25);
            this.btn_addProduct.TabIndex = 13;
            this.btn_addProduct.Text = "+";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            // 
            // btn_delProduct
            // 
            this.btn_delProduct.Location = new System.Drawing.Point(200, 231);
            this.btn_delProduct.Name = "btn_delProduct";
            this.btn_delProduct.Size = new System.Drawing.Size(50, 25);
            this.btn_delProduct.TabIndex = 14;
            this.btn_delProduct.Text = "-";
            this.btn_delProduct.UseVisualStyleBackColor = true;
            // 
            // btn_delProductkategory
            // 
            this.btn_delProductkategory.Location = new System.Drawing.Point(450, 230);
            this.btn_delProductkategory.Name = "btn_delProductkategory";
            this.btn_delProductkategory.Size = new System.Drawing.Size(50, 25);
            this.btn_delProductkategory.TabIndex = 16;
            this.btn_delProductkategory.Text = "-";
            this.btn_delProductkategory.UseVisualStyleBackColor = true;
            // 
            // btn_addProductkategory
            // 
            this.btn_addProductkategory.Location = new System.Drawing.Point(390, 230);
            this.btn_addProductkategory.Name = "btn_addProductkategory";
            this.btn_addProductkategory.Size = new System.Drawing.Size(50, 25);
            this.btn_addProductkategory.TabIndex = 15;
            this.btn_addProductkategory.Text = "+";
            this.btn_addProductkategory.UseVisualStyleBackColor = true;
            // 
            // btn_delStorageplace
            // 
            this.btn_delStorageplace.Location = new System.Drawing.Point(700, 230);
            this.btn_delStorageplace.Name = "btn_delStorageplace";
            this.btn_delStorageplace.Size = new System.Drawing.Size(50, 25);
            this.btn_delStorageplace.TabIndex = 18;
            this.btn_delStorageplace.Text = "-";
            this.btn_delStorageplace.UseVisualStyleBackColor = true;
            // 
            // btn_addStorageplace
            // 
            this.btn_addStorageplace.Location = new System.Drawing.Point(640, 230);
            this.btn_addStorageplace.Name = "btn_addStorageplace";
            this.btn_addStorageplace.Size = new System.Drawing.Size(50, 25);
            this.btn_addStorageplace.TabIndex = 17;
            this.btn_addStorageplace.Text = "+";
            this.btn_addStorageplace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
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
    }
}