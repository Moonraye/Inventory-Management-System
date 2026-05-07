using System;
using System.Windows.Forms;
using Inventory_Manager.Model;
using Inventory_Manager.Services;

namespace Inventory_Manager
{
    public partial class AddItemForm : System.Windows.Forms.Form
    {
        private readonly InventoryService _manager;

        public AddItemForm(InventoryService manager)
        {
            InitializeComponent();
            _manager = manager;

            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtName.Text;
                int article = int.Parse(txtArticle.Text);
                int count = int.Parse(txtCount.Text);
                float price = float.Parse(txtPrice.Text);
                string country = txtCountry.Text;

                Item newItem;
                if (!string.IsNullOrWhiteSpace(country))
                {
                    newItem = new ImportItem(title, country, article, count, dtpDelivered.Value, dtpExpiration.Value, price, 1);
                }
                else
                {
                    newItem = new HomelandItem(title, article, count, dtpDelivered.Value, dtpExpiration.Value, price, 1);
                }

                btnSubmit.Enabled = false;
                await _manager.AddItemAsync(newItem);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
                btnSubmit.Enabled = true;
            }
        }
    }
}