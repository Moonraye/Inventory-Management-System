using Supabase;
using Inventory_Manager.Model;

namespace Inventory_Manager.Services
{
    public class SupabaseService
    {
        private Client supabase = null!;

        public async Task InitializeAsync()
        {
            var url = "https://tlqdrqxxfrupypprozwh.supabase.co"; // URL проекту в Supabase
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InRscWRycXh4ZnJ1cHlwcHJvendoIiwicm9sZSI6ImFub24iLCJpYXQiOjE3Nzc4MDE0NjYsImV4cCI6MjA5MzM3NzQ2Nn0.__qNDMqck_b1hcmPWH4mQBoD8Y1bTA8dQaioE7ggxeE"; // Ключ API для доступу до бази даних
            var options = new SupabaseOptions { AutoConnectRealtime = true };

            supabase = new Client(url, key, options); // Створення клієнта для роботи з Supabase
            await supabase.InitializeAsync(); // Ініціалізація підключення до Supabase
        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
            var itemsList = new List<Item>(); // Список для зберігання товарів, отриманих з бази даних
            var response = await supabase.From<SupabaseItem>().Get(); // Отримання всіх записів з таблиці "items" в Supabase
            var dbItems = response.Models; // Моделі, отримані з бази даних, які відповідають класу SupabaseItem

            foreach (var dbItem in dbItems)  // Проходимо по кожному запису з бази даних і створюємо відповідний об'єкт Item (ImportItem або HomelandItem) залежно від типу товару
            {
                if (dbItem.ItemType == "Import")
                {
                    itemsList.Add(new ImportItem(dbItem.Title, dbItem.ProducerCountry ?? "", dbItem.Article, dbItem.Count, dbItem.DeliveredAt, dbItem.ExpirationDate, dbItem.Price, dbItem.Category));
                }
                else
                {
                    itemsList.Add(new HomelandItem(dbItem.Title, dbItem.Article, dbItem.Count, dbItem.DeliveredAt, dbItem.ExpirationDate, dbItem.Price, dbItem.Category));
                }
            }

            return itemsList;
        }

        public async Task InsertItemAsync(Item item) // Асинхронне додавання нового товару
        {
            var dbItem = new SupabaseItem
            {
                Title = item.Title,
                Article = item.Article,
                Count = item.Count,
                DeliveredAt = item.DeliveredAt,
                ExpirationDate = item.ExpirationDate,
                Price = item.Price,
                Category = item.Category,
                ItemType = item.ItemType
            };

            if (item is ImportItem importItem)
            {
                dbItem.ProducerCountry = importItem.ProducerCountry;
            }

            await supabase.From<SupabaseItem>().Insert(dbItem); // Вставка нового запису в таблицю "items" в Supabase
        }

        public async Task<bool> DeleteItemAsync(int article) // Асинхронне видалення товару за артикулом
        {
           
                await supabase.From<SupabaseItem>()
                              .Where(x => x.Article == article)
                              .Delete();
                return true;
           
        }
        public async Task UpdatePriceAsync(int article, float newPrice) // Асинхронне оновлення ціни товару за артикулом
        {
                // Оновлення в Supabase
                await supabase.From<SupabaseItem>()
                              .Where(x => x.Article == article)
                              .Set(x => x.Price, newPrice)
                              .Update();
        }
    }
}