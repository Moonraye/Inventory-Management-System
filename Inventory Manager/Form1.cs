using Inventory_Manager.Services;
using System.Xml.Linq;

namespace Inventory_Manager
{
    public partial class Form : System.Windows.Forms.Form
    {
        private InventoryService manager = null!;
        private SupabaseService dbService = null!;
        public Form()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
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
                MessageBox.Show($"Error DB connecting: {ex.Message}");
                return;
            }
        }

        private void RefreshGrid(object dataSource)
        {
            dataGridViewItems.DataSource = null;
            dataGridViewItems.DataSource = dataSource;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитуємо дані з усіх полів
                string title = txtName.Text;
                int article = int.Parse(txtArticle.Text);
                int count = int.Parse(txtCount.Text);
                float price = float.Parse(txtPrice.Text);
                DateTime deliveredAt = dtpDelivered.Value;
                DateTime expirationDate = dtpExpiration.Value;

                // Для спрощення задамо категорію за замовчуванням (або можеш додати ще один TextBox для неї)
                int category = 1;
                string country = txtCountry.Text;

                // 2. Визначаємо тип товару
                Inventory_Manager.Model.Item newItem;

                // Якщо поле країни не порожнє - значить це імпортний товар
                if (!string.IsNullOrWhiteSpace(country))
                {
                    newItem = new Inventory_Manager.Model.ImportItem(title, country, article, count, deliveredAt, expirationDate, price, category);
                }
                else // Якщо порожнє - вітчизняний
                {
                    newItem = new Inventory_Manager.Model.HomelandItem(title, article, count, deliveredAt, expirationDate, price, category);
                }

                // 3. Відправляємо в базу даних та оновлюємо таблицю
                await manager.AddItemAsync(newItem);
                RefreshGrid(manager.GetAllItems());

                MessageBox.Show("Товар успішно додано!");

                // Очищаємо поля після успішного додавання
                txtName.Clear();
                txtArticle.Clear();
                txtCount.Clear();
                txtPrice.Clear();
                txtCountry.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка: перевірте правильність введених чисел (артикул, кількість, ціна).");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні товару: {ex.Message}");
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArticle.Text, out int article))
            {
                bool success = await manager.RemoveItemAsync(article);
                if (success)
                {
                    RefreshGrid(manager.GetAllItems());
                    MessageBox.Show("Товар успішно видалено!");
                }
                else
                {
                    MessageBox.Show("Товар з таким артикулом не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Введіть коректний артикул.");
            }
        }
        private async void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArticle.Text, out int article) && float.TryParse(txtPrice.Text, out float newPrice))
            {
                bool success = await manager.UpdatePriceAsync(article, newPrice);
                if (success)
                {
                    RefreshGrid(manager.GetAllItems());
                    MessageBox.Show("Ціну успішно оновлено!");
                }
                else
                {
                    MessageBox.Show("Товар з таким артикулом не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Перевірте правильність введеного артикулу та ціни.");
            }
        }
        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetItemsSortedByPrice());
        }

        private void btnFilterHomeland_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetHomelandItems());
        }

        private void btnFilterImport_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetImportItems());
        }

        private void btnSearchArticle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArticle.Text, out int article))
            {
                var item = manager.SearchByArticle(article);
                if (item != null)
                {
                    RefreshGrid(new List<Inventory_Manager.Model.Item> { item });
                }
                else
                {
                    MessageBox.Show("Товар не знайдено!");
                }
            }
        }

        private void btnSearchNameCountry_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string country = txtCountry.Text;

            var results = manager.SearchByNameAndCountry(name, country);
            RefreshGrid(results);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshGrid(manager.GetAllItems());
        }
    }
}
