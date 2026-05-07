namespace Inventory_Manager
{
    partial class MainForm
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
            Label priceLabel;
            Label articleLabel;
            Label nameLabel;
            Label countryLabel;
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnDelete = new Button();
            btnSearchArticle = new Button();
            btnUpdatePrice = new Button();
            btnFilterImport = new Button();
            btnFilterHomeland = new Button();
            btnSortPrice = new Button();
            btnSearchNameCountry = new Button();
            btnReset = new Button();
            dataGridViewItems = new DataGridView();
            Aside = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Table = new Panel();
            txtPrice = new TextBox();
            txtArticle = new TextBox();
            btnAddOpenModal = new Button();
            txtName = new TextBox();
            txtCountry = new TextBox();
            Main = new Panel();
            EntersGroup = new Panel();
            priceLabel = new Label();
            articleLabel = new Label();
            nameLabel = new Label();
            countryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            Aside.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            Table.SuspendLayout();
            Main.SuspendLayout();
            EntersGroup.SuspendLayout();
            SuspendLayout();
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.None;
            priceLabel.AutoEllipsis = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.BorderStyle = BorderStyle.FixedSingle;
            priceLabel.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            priceLabel.ForeColor = Color.White;
            priceLabel.Location = new Point(212, 280);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(148, 29);
            priceLabel.TabIndex = 35;
            priceLabel.Text = "Enter Price";
            // 
            // articleLabel
            // 
            articleLabel.Anchor = AnchorStyles.None;
            articleLabel.AutoEllipsis = true;
            articleLabel.BackColor = Color.Transparent;
            articleLabel.BorderStyle = BorderStyle.FixedSingle;
            articleLabel.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            articleLabel.ForeColor = Color.White;
            articleLabel.Location = new Point(34, 280);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new Size(165, 29);
            articleLabel.TabIndex = 34;
            articleLabel.Text = "Enter Article";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoEllipsis = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.BorderStyle = BorderStyle.FixedSingle;
            nameLabel.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(34, 198);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(165, 29);
            nameLabel.TabIndex = 42;
            nameLabel.Text = "Enter Name";
            // 
            // countryLabel
            // 
            countryLabel.Anchor = AnchorStyles.None;
            countryLabel.AutoEllipsis = true;
            countryLabel.BackColor = Color.Transparent;
            countryLabel.BorderStyle = BorderStyle.FixedSingle;
            countryLabel.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            countryLabel.ForeColor = Color.White;
            countryLabel.Location = new Point(193, 198);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(199, 29);
            countryLabel.TabIndex = 43;
            countryLabel.Text = "Enter Country";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(30, 30, 30);
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(174, 153, 117);
            btnDelete.Location = new Point(0, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(289, 83);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchArticle
            // 
            btnSearchArticle.BackColor = Color.FromArgb(30, 30, 30);
            btnSearchArticle.BackgroundImageLayout = ImageLayout.None;
            btnSearchArticle.Dock = DockStyle.Fill;
            btnSearchArticle.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnSearchArticle.FlatStyle = FlatStyle.Flat;
            btnSearchArticle.ForeColor = Color.FromArgb(174, 153, 117);
            btnSearchArticle.Location = new Point(0, 498);
            btnSearchArticle.Margin = new Padding(0);
            btnSearchArticle.Name = "btnSearchArticle";
            btnSearchArticle.Size = new Size(289, 83);
            btnSearchArticle.TabIndex = 3;
            btnSearchArticle.Text = "SEARCH BY ARTICLE";
            btnSearchArticle.UseVisualStyleBackColor = false;
            btnSearchArticle.Click += btnSearchArticle_Click;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.BackColor = Color.FromArgb(30, 30, 30);
            btnUpdatePrice.BackgroundImageLayout = ImageLayout.None;
            btnUpdatePrice.Dock = DockStyle.Fill;
            btnUpdatePrice.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnUpdatePrice.FlatStyle = FlatStyle.Flat;
            btnUpdatePrice.ForeColor = Color.FromArgb(174, 153, 117);
            btnUpdatePrice.Location = new Point(0, 166);
            btnUpdatePrice.Margin = new Padding(0);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(289, 83);
            btnUpdatePrice.TabIndex = 4;
            btnUpdatePrice.Text = "UPDATE ITEM PRICE";
            btnUpdatePrice.UseVisualStyleBackColor = false;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // btnFilterImport
            // 
            btnFilterImport.BackColor = Color.FromArgb(30, 30, 30);
            btnFilterImport.BackgroundImageLayout = ImageLayout.None;
            btnFilterImport.Dock = DockStyle.Fill;
            btnFilterImport.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnFilterImport.FlatStyle = FlatStyle.Flat;
            btnFilterImport.ForeColor = Color.FromArgb(174, 153, 117);
            btnFilterImport.Location = new Point(0, 249);
            btnFilterImport.Margin = new Padding(0);
            btnFilterImport.Name = "btnFilterImport";
            btnFilterImport.Size = new Size(289, 83);
            btnFilterImport.TabIndex = 5;
            btnFilterImport.Text = "SHOW IMPORT ITEMS";
            btnFilterImport.UseVisualStyleBackColor = false;
            btnFilterImport.Click += btnFilterImport_Click;
            // 
            // btnFilterHomeland
            // 
            btnFilterHomeland.BackColor = Color.FromArgb(30, 30, 30);
            btnFilterHomeland.BackgroundImageLayout = ImageLayout.None;
            btnFilterHomeland.Dock = DockStyle.Fill;
            btnFilterHomeland.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnFilterHomeland.FlatStyle = FlatStyle.Flat;
            btnFilterHomeland.ForeColor = Color.FromArgb(174, 153, 117);
            btnFilterHomeland.Location = new Point(0, 332);
            btnFilterHomeland.Margin = new Padding(0);
            btnFilterHomeland.Name = "btnFilterHomeland";
            btnFilterHomeland.Size = new Size(289, 83);
            btnFilterHomeland.TabIndex = 6;
            btnFilterHomeland.Text = "SHOW HOMELAND";
            btnFilterHomeland.UseVisualStyleBackColor = false;
            btnFilterHomeland.Click += btnFilterHomeland_Click;
            // 
            // btnSortPrice
            // 
            btnSortPrice.BackColor = Color.FromArgb(30, 30, 30);
            btnSortPrice.BackgroundImageLayout = ImageLayout.None;
            btnSortPrice.Dock = DockStyle.Fill;
            btnSortPrice.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnSortPrice.FlatStyle = FlatStyle.Flat;
            btnSortPrice.ForeColor = Color.FromArgb(174, 153, 117);
            btnSortPrice.Location = new Point(0, 581);
            btnSortPrice.Margin = new Padding(0);
            btnSortPrice.MaximumSize = new Size(310, 130);
            btnSortPrice.Name = "btnSortPrice";
            btnSortPrice.Size = new Size(289, 90);
            btnSortPrice.TabIndex = 7;
            btnSortPrice.Text = "SORT BY PRICE";
            btnSortPrice.UseVisualStyleBackColor = false;
            btnSortPrice.Click += btnSortPrice_Click;
            // 
            // btnSearchNameCountry
            // 
            btnSearchNameCountry.BackColor = Color.FromArgb(30, 30, 30);
            btnSearchNameCountry.BackgroundImageLayout = ImageLayout.None;
            btnSearchNameCountry.Dock = DockStyle.Fill;
            btnSearchNameCountry.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnSearchNameCountry.FlatStyle = FlatStyle.Flat;
            btnSearchNameCountry.ForeColor = Color.FromArgb(174, 153, 117);
            btnSearchNameCountry.Location = new Point(0, 415);
            btnSearchNameCountry.Margin = new Padding(0);
            btnSearchNameCountry.Name = "btnSearchNameCountry";
            btnSearchNameCountry.Size = new Size(289, 83);
            btnSearchNameCountry.TabIndex = 8;
            btnSearchNameCountry.Text = "SEARCH BY COUNTRY";
            btnSearchNameCountry.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchNameCountry.UseVisualStyleBackColor = false;
            btnSearchNameCountry.Click += btnSearchNameCountry_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(30, 30, 30);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.Dock = DockStyle.Fill;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.FromArgb(174, 153, 117);
            btnReset.Location = new Point(0, 83);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(289, 83);
            btnReset.TabIndex = 9;
            btnReset.Text = "RESET FILTERS";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.BackgroundColor = Color.FromArgb(22, 22, 22);
            dataGridViewItems.BorderStyle = BorderStyle.None;
            dataGridViewItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(174, 153, 117);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(174, 153, 117);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewItems.Dock = DockStyle.Fill;
            dataGridViewItems.EnableHeadersVisualStyles = false;
            dataGridViewItems.GridColor = Color.FromArgb(45, 45, 48);
            dataGridViewItems.Location = new Point(0, 0);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersVisible = false;
            dataGridViewItems.Size = new Size(813, 671);
            dataGridViewItems.TabIndex = 36;
            // 
            // Aside
            // 
            Aside.Controls.Add(tableLayoutPanel1);
            Aside.Cursor = Cursors.Hand;
            Aside.Dock = DockStyle.Left;
            Aside.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            Aside.ForeColor = Color.FromArgb(174, 153, 117);
            Aside.Location = new Point(0, 0);
            Aside.Name = "Aside";
            Aside.Size = new Size(289, 671);
            Aside.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnFilterHomeland, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSearchArticle, 0, 6);
            tableLayoutPanel1.Controls.Add(btnSearchNameCountry, 0, 5);
            tableLayoutPanel1.Controls.Add(btnFilterImport, 0, 3);
            tableLayoutPanel1.Controls.Add(btnUpdatePrice, 0, 2);
            tableLayoutPanel1.Controls.Add(btnReset, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDelete, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSortPrice, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(289, 671);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // Table
            // 
            Table.Controls.Add(dataGridViewItems);
            Table.Dock = DockStyle.Right;
            Table.Location = new Point(771, 0);
            Table.Name = "Table";
            Table.Size = new Size(813, 671);
            Table.TabIndex = 36;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.BackColor = Color.FromArgb(30, 30, 30);
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            txtPrice.ForeColor = Color.FromArgb(230, 230, 230);
            txtPrice.Location = new Point(202, 328);
            txtPrice.MaximumSize = new Size(163, 33);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(163, 33);
            txtPrice.TabIndex = 32;
            // 
            // txtArticle
            // 
            txtArticle.Anchor = AnchorStyles.None;
            txtArticle.BackColor = Color.FromArgb(30, 30, 30);
            txtArticle.BorderStyle = BorderStyle.FixedSingle;
            txtArticle.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            txtArticle.ForeColor = Color.FromArgb(230, 230, 230);
            txtArticle.Location = new Point(33, 328);
            txtArticle.MaximumSize = new Size(163, 33);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(163, 33);
            txtArticle.TabIndex = 33;
            // 
            // btnAddOpenModal
            // 
            btnAddOpenModal.Anchor = AnchorStyles.None;
            btnAddOpenModal.BackColor = Color.FromArgb(30, 30, 30);
            btnAddOpenModal.Cursor = Cursors.Hand;
            btnAddOpenModal.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnAddOpenModal.FlatStyle = FlatStyle.Flat;
            btnAddOpenModal.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            btnAddOpenModal.ForeColor = Color.FromArgb(174, 153, 117);
            btnAddOpenModal.Location = new Point(59, 450);
            btnAddOpenModal.MaximumSize = new Size(292, 69);
            btnAddOpenModal.Name = "btnAddOpenModal";
            btnAddOpenModal.Size = new Size(292, 61);
            btnAddOpenModal.TabIndex = 19;
            btnAddOpenModal.Text = "ADD NEW ITEM";
            btnAddOpenModal.UseVisualStyleBackColor = false;
            btnAddOpenModal.Click += btnAddOpenModal_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.FromArgb(30, 30, 30);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            txtName.ForeColor = Color.FromArgb(230, 230, 230);
            txtName.Location = new Point(33, 236);
            txtName.MaximumSize = new Size(163, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 33);
            txtName.TabIndex = 40;
            // 
            // txtCountry
            // 
            txtCountry.Anchor = AnchorStyles.None;
            txtCountry.BackColor = Color.FromArgb(30, 30, 30);
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold);
            txtCountry.ForeColor = Color.FromArgb(230, 230, 230);
            txtCountry.Location = new Point(202, 236);
            txtCountry.MaximumSize = new Size(163, 33);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(163, 33);
            txtCountry.TabIndex = 41;
            // 
            // Main
            // 
            Main.Controls.Add(EntersGroup);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(289, 0);
            Main.Name = "Main";
            Main.Size = new Size(482, 671);
            Main.TabIndex = 39;
            Main.Paint += Main_Paint;
            // 
            // EntersGroup
            // 
            EntersGroup.Anchor = AnchorStyles.None;
            EntersGroup.Controls.Add(btnAddOpenModal);
            EntersGroup.Controls.Add(countryLabel);
            EntersGroup.Controls.Add(txtPrice);
            EntersGroup.Controls.Add(nameLabel);
            EntersGroup.Controls.Add(txtArticle);
            EntersGroup.Controls.Add(txtCountry);
            EntersGroup.Controls.Add(priceLabel);
            EntersGroup.Controls.Add(txtName);
            EntersGroup.Controls.Add(articleLabel);
            EntersGroup.Location = new Point(40, -15);
            EntersGroup.Name = "EntersGroup";
            EntersGroup.Size = new Size(402, 743);
            EntersGroup.TabIndex = 44;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            CausesValidation = false;
            ClientSize = new Size(1584, 671);
            Controls.Add(Main);
            Controls.Add(Aside);
            Controls.Add(Table);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1482, 377);
            Name = "MainForm";
            Text = "Inventory Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            Aside.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            Table.ResumeLayout(false);
            Main.ResumeLayout(false);
            EntersGroup.ResumeLayout(false);
            EntersGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDelete;
        private Button btnSearchArticle;
        private Button btnUpdatePrice;
        private Button btnFilterImport;
        private Button btnFilterHomeland;
        private Button btnSortPrice;
        private Button btnSearchNameCountry;
        private Button btnReset;
        private DataGridView dataGridViewItems;
        private Panel Aside;
        private Panel Table;
        private TextBox txtPrice;
        private TextBox txtArticle;
        private Button btnAddOpenModal;
        private TextBox txtName;
        private TextBox txtCountry;
        private Panel Main;
        private Panel EntersGroup;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
