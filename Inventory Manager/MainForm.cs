using Inventory_Manager.Model;
using Inventory_Manager.Services;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Inventory_Manager
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private InventoryService manager = null!;
        private SupabaseService dbService = null!;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                dbService = new SupabaseService();
                await dbService.InitializeAsync();

                manager = new InventoryService(dbService);
                await manager.LoadFromDatabaseAsync();

                RefreshGrid(manager.GetAllItems());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка підключення: {ex.Message}");
            }
        }

        private void RefreshGrid(object dataSource)
        {
            dataGridViewItems.DataSource = null;
            dataGridViewItems.DataSource = dataSource;
        }

        // Відкриття модального вікна для додавання
        private void btnAddOpenModal_Click(object sender, EventArgs e)
        {
            using (AddItemForm addForm = new AddItemForm(manager))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid(manager.GetAllItems());
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Переконайся, що txtArticle є на формі Layout
            if (int.TryParse(txtArticle.Text, out int article))
            {
                bool success = await manager.RemoveItemAsync(article);
                if (success)
                {
                    RefreshGrid(manager.GetAllItems());
                    MessageBox.Show("Товар видалено!");
                }
                else MessageBox.Show("Товар не знайдено.");
            }
        }

        private async void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            // Переконайся, що txtArticle та txtPrice є на формі Layout
            if (int.TryParse(txtArticle.Text, out int article) && float.TryParse(txtPrice.Text, out float newPrice))
            {
                bool success = await manager.UpdatePriceAsync(article, newPrice);
                if (success)
                {
                    RefreshGrid(manager.GetAllItems());
                    MessageBox.Show("Ціну оновлено!");
                }
            }
        }

        private void btnFilterHomeland_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetHomelandItems());
        }

        private void btnFilterImport_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetImportItems());
        }

        private void btnSearchNameCountry_Click(object sender, EventArgs e)
        {
            // Переконайся, що поля txtName та txtCountry все ще є на твоїй головній формі
            // Якщо ти їх переніс тільки в модалку, цей пошук не знайде звідки брати текст
            string name = txtName.Text;
            string country = txtCountry.Text;

            var results = manager.SearchByNameAndCountry(name, country);
            RefreshGrid(results);
        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetItemsSortedByPrice());
        }

        private void btnSearchArticle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArticle.Text, out int article))
            {
                var item = manager.SearchByArticle(article);
                if (item != null)
                    RefreshGrid(new List<Item> { item });
                else
                    MessageBox.Show("Не знайдено!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetAllItems());
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}