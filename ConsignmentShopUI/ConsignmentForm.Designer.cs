namespace ConsignmentShopUI
{
    partial class ConsignmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consignmentShopLabel = new System.Windows.Forms.Label();
            this.storeItemsLabel = new System.Windows.Forms.Label();
            this.itemslistBox = new System.Windows.Forms.ListBox();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.vendorsListBox = new System.Windows.Forms.ListBox();
            this.VendorsLabel = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consignmentShopLabel
            // 
            this.consignmentShopLabel.AutoSize = true;
            this.consignmentShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consignmentShopLabel.Location = new System.Drawing.Point(34, 28);
            this.consignmentShopLabel.Name = "consignmentShopLabel";
            this.consignmentShopLabel.Size = new System.Drawing.Size(285, 36);
            this.consignmentShopLabel.TabIndex = 0;
            this.consignmentShopLabel.Text = "Consignment Shop";
            // 
            // storeItemsLabel
            // 
            this.storeItemsLabel.AutoSize = true;
            this.storeItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeItemsLabel.Location = new System.Drawing.Point(37, 113);
            this.storeItemsLabel.Name = "storeItemsLabel";
            this.storeItemsLabel.Size = new System.Drawing.Size(146, 29);
            this.storeItemsLabel.TabIndex = 1;
            this.storeItemsLabel.Text = "Store Items";
            // 
            // itemslistBox
            // 
            this.itemslistBox.FormattingEnabled = true;
            this.itemslistBox.ItemHeight = 16;
            this.itemslistBox.Location = new System.Drawing.Point(40, 168);
            this.itemslistBox.Name = "itemslistBox";
            this.itemslistBox.Size = new System.Drawing.Size(391, 260);
            this.itemslistBox.TabIndex = 2;
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 16;
            this.shoppingCartListBox.Location = new System.Drawing.Point(692, 168);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(391, 260);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.Location = new System.Drawing.Point(687, 113);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(180, 29);
            this.shoppingCartLabel.TabIndex = 3;
            this.shoppingCartLabel.Text = "Shopping Cart";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(481, 277);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(140, 57);
            this.addToCartButton.TabIndex = 5;
            this.addToCartButton.Text = "Add To Cart -->";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(943, 442);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(140, 57);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // vendorsListBox
            // 
            this.vendorsListBox.FormattingEnabled = true;
            this.vendorsListBox.ItemHeight = 16;
            this.vendorsListBox.Location = new System.Drawing.Point(51, 499);
            this.vendorsListBox.Name = "vendorsListBox";
            this.vendorsListBox.Size = new System.Drawing.Size(391, 260);
            this.vendorsListBox.TabIndex = 8;
            // 
            // VendorsLabel
            // 
            this.VendorsLabel.AutoSize = true;
            this.VendorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsLabel.Location = new System.Drawing.Point(46, 460);
            this.VendorsLabel.Name = "VendorsLabel";
            this.VendorsLabel.Size = new System.Drawing.Size(110, 29);
            this.VendorsLabel.TabIndex = 7;
            this.VendorsLabel.Text = "Vendors";
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(687, 560);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(145, 29);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(855, 560);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(76, 29);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 771);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorsListBox);
            this.Controls.Add(this.VendorsLabel);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.itemslistBox);
            this.Controls.Add(this.storeItemsLabel);
            this.Controls.Add(this.consignmentShopLabel);
            this.Name = "ConsignmentForm";
            this.Text = "Consignment Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consignmentShopLabel;
        private System.Windows.Forms.Label storeItemsLabel;
        private System.Windows.Forms.ListBox itemslistBox;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.ListBox vendorsListBox;
        private System.Windows.Forms.Label VendorsLabel;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

