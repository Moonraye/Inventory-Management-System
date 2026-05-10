namespace Inventory_Manager
{
    partial class AddItemForm
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
            Label countryLabel;
            Label nameLabel;
            Label priceLabel;
            Label articleLabel;
            expirationDate = new Label();
            deliveryLabel = new Label();
            dtpExpiration = new DateTimePicker();
            dtpDelivered = new DateTimePicker();
            countLabel = new Label();
            txtCount = new TextBox();
            txtArticle = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtCountry = new TextBox();
            btnSubmit = new Button();
            AddItemPanel = new Panel();
            countryLabel = new Label();
            nameLabel = new Label();
            priceLabel = new Label();
            articleLabel = new Label();
            AddItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // countryLabel
            // 
            countryLabel.AutoEllipsis = true;
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 14F);
            countryLabel.ForeColor = Color.White;
            countryLabel.Location = new Point(319, 14);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(128, 25);
            countryLabel.TabIndex = 33;
            countryLabel.Text = "Enter Country";
            // 
            // nameLabel
            // 
            nameLabel.AutoEllipsis = true;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14F);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(3, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(111, 25);
            nameLabel.TabIndex = 32;
            nameLabel.Text = "Enter Name";
            // 
            // priceLabel
            // 
            priceLabel.AutoEllipsis = true;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 14F);
            priceLabel.ForeColor = Color.White;
            priceLabel.Location = new Point(220, 13);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(103, 25);
            priceLabel.TabIndex = 31;
            priceLabel.Text = "Enter Price";
            // 
            // articleLabel
            // 
            articleLabel.AutoEllipsis = true;
            articleLabel.AutoSize = true;
            articleLabel.Font = new Font("Segoe UI", 14F);
            articleLabel.ForeColor = Color.White;
            articleLabel.Location = new Point(109, 12);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new Size(115, 25);
            articleLabel.TabIndex = 30;
            articleLabel.Text = "Enter Article";
            // 
            // expirationDate
            // 
            expirationDate.AutoSize = true;
            expirationDate.Font = new Font("Segoe UI", 14F);
            expirationDate.Location = new Point(245, 93);
            expirationDate.Name = "expirationDate";
            expirationDate.Size = new Size(190, 25);
            expirationDate.TabIndex = 39;
            expirationDate.Text = "Enter Expiration Date";
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Font = new Font("Segoe UI", 14F);
            deliveryLabel.Location = new Point(20, 93);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new Size(173, 25);
            deliveryLabel.TabIndex = 38;
            deliveryLabel.Text = "Enter Delivery Date";
            // 
            // dtpExpiration
            // 
            dtpExpiration.Location = new Point(235, 121);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(200, 23);
            dtpExpiration.TabIndex = 37;
            // 
            // dtpDelivered
            // 
            dtpDelivered.Location = new Point(8, 121);
            dtpDelivered.Name = "dtpDelivered";
            dtpDelivered.Size = new Size(200, 23);
            dtpDelivered.TabIndex = 36;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI", 14F);
            countLabel.ForeColor = Color.White;
            countLabel.Location = new Point(164, 157);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(112, 25);
            countLabel.TabIndex = 35;
            countLabel.Text = "Enter Count";
            // 
            // txtCount
            // 
            txtCount.BackColor = Color.White;
            txtCount.ForeColor = Color.Black;
            txtCount.Location = new Point(142, 185);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(161, 23);
            txtCount.TabIndex = 34;
            // 
            // txtArticle
            // 
            txtArticle.BackColor = Color.White;
            txtArticle.Location = new Point(116, 41);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(100, 23);
            txtArticle.TabIndex = 29;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Location = new Point(226, 41);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(7, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 27;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.White;
            txtCountry.Location = new Point(335, 41);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 26;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(22, 22, 22);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 14F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(131, 238);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(181, 66);
            btnSubmit.TabIndex = 40;
            btnSubmit.Text = "ADD ITEM";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddItemPanel
            // 
            AddItemPanel.Controls.Add(btnSubmit);
            AddItemPanel.Controls.Add(expirationDate);
            AddItemPanel.Controls.Add(txtCountry);
            AddItemPanel.Controls.Add(deliveryLabel);
            AddItemPanel.Controls.Add(txtName);
            AddItemPanel.Controls.Add(dtpExpiration);
            AddItemPanel.Controls.Add(txtPrice);
            AddItemPanel.Controls.Add(dtpDelivered);
            AddItemPanel.Controls.Add(txtArticle);
            AddItemPanel.Controls.Add(countLabel);
            AddItemPanel.Controls.Add(articleLabel);
            AddItemPanel.Controls.Add(txtCount);
            AddItemPanel.Controls.Add(priceLabel);
            AddItemPanel.Controls.Add(countryLabel);
            AddItemPanel.Controls.Add(nameLabel);
            AddItemPanel.Dock = DockStyle.Fill;
            AddItemPanel.Location = new Point(0, 0);
            AddItemPanel.MaximumSize = new Size(447, 307);
            AddItemPanel.MinimumSize = new Size(447, 307);
            AddItemPanel.Name = "AddItemPanel";
            AddItemPanel.Size = new Size(447, 307);
            AddItemPanel.TabIndex = 41;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(448, 314);
            Controls.Add(AddItemPanel);
            ForeColor = Color.White;
            MaximumSize = new Size(464, 353);
            MinimumSize = new Size(464, 353);
            Name = "AddItemForm";
            Text = "AddItemForm";
            AddItemPanel.ResumeLayout(false);
            AddItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label expirationDate;
        private Label deliveryLabel;
        private DateTimePicker dtpExpiration;
        private DateTimePicker dtpDelivered;
        private Label countLabel;
        private TextBox txtCount;
        private TextBox txtArticle;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtCountry;
        private Button btnSubmit;
        private Panel AddItemPanel;
    }
}