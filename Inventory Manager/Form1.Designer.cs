namespace Inventory_Manager
{
    partial class Form
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
            Label articleLabel;
            Label priceLabel;
            Label nameLabel;
            Label countryLabel;
            dataGridViewItems = new DataGridView();
            label1 = new Label();
            btnDelete = new Button();
            btnSearchArticle = new Button();
            btnUpdatePrice = new Button();
            btnFilterImport = new Button();
            btnFilterHomeland = new Button();
            btnSortPrice = new Button();
            btnSearchNameCountry = new Button();
            btnReset = new Button();
            txtCountry = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtArticle = new TextBox();
            btnAdd = new Button();
            txtCount = new TextBox();
            countLabel = new Label();
            dtpDelivered = new DateTimePicker();
            dtpExpiration = new DateTimePicker();
            deliveryLabel = new Label();
            expirationDate = new Label();
            articleLabel = new Label();
            priceLabel = new Label();
            nameLabel = new Label();
            countryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // articleLabel
            // 
            articleLabel.AutoEllipsis = true;
            articleLabel.AutoSize = true;
            articleLabel.Font = new Font("Segoe UI", 14F);
            articleLabel.Location = new Point(258, 193);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new Size(115, 25);
            articleLabel.TabIndex = 15;
            articleLabel.Text = "Enter Article";
            // 
            // priceLabel
            // 
            priceLabel.AutoEllipsis = true;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 14F);
            priceLabel.Location = new Point(369, 194);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(103, 25);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "Enter Price";
            // 
            // nameLabel
            // 
            nameLabel.AutoEllipsis = true;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14F);
            nameLabel.Location = new Point(152, 193);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(111, 25);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Enter Name";
            // 
            // countryLabel
            // 
            countryLabel.AutoEllipsis = true;
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 14F);
            countryLabel.Location = new Point(468, 195);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(128, 25);
            countryLabel.TabIndex = 18;
            countryLabel.Text = "Enter Country";
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(602, 90);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.Size = new Size(588, 428);
            dataGridViewItems.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(393, 9);
            label1.Name = "label1";
            label1.Size = new Size(432, 54);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGER";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(157, 89);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchArticle
            // 
            btnSearchArticle.Location = new Point(369, 89);
            btnSearchArticle.Name = "btnSearchArticle";
            btnSearchArticle.Size = new Size(100, 38);
            btnSearchArticle.TabIndex = 3;
            btnSearchArticle.Text = "SEARCH BY ARTICLE";
            btnSearchArticle.UseVisualStyleBackColor = true;
            btnSearchArticle.Click += btnSearchArticle_Click;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.Location = new Point(157, 133);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(100, 38);
            btnUpdatePrice.TabIndex = 4;
            btnUpdatePrice.Text = "UPDATE ITEM PRICE";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // btnFilterImport
            // 
            btnFilterImport.Location = new Point(263, 133);
            btnFilterImport.Name = "btnFilterImport";
            btnFilterImport.Size = new Size(100, 38);
            btnFilterImport.TabIndex = 5;
            btnFilterImport.Text = "SHOW IMPORT ITEMS";
            btnFilterImport.UseVisualStyleBackColor = true;
            btnFilterImport.Click += btnFilterImport_Click;
            // 
            // btnFilterHomeland
            // 
            btnFilterHomeland.Location = new Point(263, 89);
            btnFilterHomeland.Name = "btnFilterHomeland";
            btnFilterHomeland.Size = new Size(100, 38);
            btnFilterHomeland.TabIndex = 6;
            btnFilterHomeland.Text = "SHOW HOMELAND ITEMS";
            btnFilterHomeland.UseVisualStyleBackColor = true;
            btnFilterHomeland.Click += btnFilterHomeland_Click;
            // 
            // btnSortPrice
            // 
            btnSortPrice.Location = new Point(475, 89);
            btnSortPrice.Name = "btnSortPrice";
            btnSortPrice.Size = new Size(100, 38);
            btnSortPrice.TabIndex = 7;
            btnSortPrice.Text = "SORT BY PRICE";
            btnSortPrice.UseVisualStyleBackColor = true;
            btnSortPrice.Click += btnSortPrice_Click;
            // 
            // btnSearchNameCountry
            // 
            btnSearchNameCountry.Location = new Point(369, 133);
            btnSearchNameCountry.Name = "btnSearchNameCountry";
            btnSearchNameCountry.Size = new Size(100, 38);
            btnSearchNameCountry.TabIndex = 8;
            btnSearchNameCountry.Text = "SEARCH BY COUNTRY NAME";
            btnSearchNameCountry.UseVisualStyleBackColor = true;
            btnSearchNameCountry.Click += btnSearchNameCountry_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(475, 133);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 38);
            btnReset.TabIndex = 9;
            btnReset.Text = "RESET FILTERS";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(475, 222);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 222);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(370, 222);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtArticle
            // 
            txtArticle.Location = new Point(264, 222);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(100, 23);
            txtArticle.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(285, 434);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 44);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "ADD NEW ITEM";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(285, 405);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(161, 23);
            txtCount.TabIndex = 20;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI", 14F);
            countLabel.Location = new Point(316, 370);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(112, 25);
            countLabel.TabIndex = 21;
            countLabel.Text = "Enter Count";
            // 
            // dtpDelivered
            // 
            dtpDelivered.Location = new Point(157, 302);
            dtpDelivered.Name = "dtpDelivered";
            dtpDelivered.Size = new Size(200, 23);
            dtpDelivered.TabIndex = 22;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Location = new Point(375, 302);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(200, 23);
            dtpExpiration.TabIndex = 23;
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Font = new Font("Segoe UI", 14F);
            deliveryLabel.Location = new Point(173, 274);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new Size(173, 25);
            deliveryLabel.TabIndex = 24;
            deliveryLabel.Text = "Enter Delivery Date";
            // 
            // expirationDate
            // 
            expirationDate.AutoSize = true;
            expirationDate.Font = new Font("Segoe UI", 14F);
            expirationDate.Location = new Point(375, 274);
            expirationDate.Name = "expirationDate";
            expirationDate.Size = new Size(190, 25);
            expirationDate.TabIndex = 25;
            expirationDate.Text = "Enter Expiration Date";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            CausesValidation = false;
            ClientSize = new Size(1202, 579);
            Controls.Add(expirationDate);
            Controls.Add(deliveryLabel);
            Controls.Add(dtpExpiration);
            Controls.Add(dtpDelivered);
            Controls.Add(countLabel);
            Controls.Add(txtCount);
            Controls.Add(btnAdd);
            Controls.Add(countryLabel);
            Controls.Add(nameLabel);
            Controls.Add(priceLabel);
            Controls.Add(articleLabel);
            Controls.Add(txtArticle);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtCountry);
            Controls.Add(btnReset);
            Controls.Add(btnSearchNameCountry);
            Controls.Add(btnSortPrice);
            Controls.Add(btnFilterHomeland);
            Controls.Add(btnFilterImport);
            Controls.Add(btnUpdatePrice);
            Controls.Add(btnSearchArticle);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(dataGridViewItems);
            Name = "Form";
            Text = "Inventory Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewItems;
        private Label label1;
        private Button btnDelete;
        private Button btnSearchArticle;
        private Button btnUpdatePrice;
        private Button btnFilterImport;
        private Button btnFilterHomeland;
        private Button btnSortPrice;
        private Button btnSearchNameCountry;
        private Button btnReset;
        private TextBox txtCountry;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtArticle;
        private Label articleLabel;
        private Button btnAdd;
        private TextBox txtCount;
        private Label countLabel;
        private DateTimePicker dtpDelivered;
        private DateTimePicker dtpExpiration;
        private Label deliveryLabel;
        private Label expirationDate;
    }
}
