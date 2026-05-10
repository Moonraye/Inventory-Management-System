using Inventory_Manager.Model;

namespace Inventory_Manager.Services
{
    public class InventoryService
    {
        private List<Item> inventory; // Створюємо список для зберігання товарів в пам'яті

        private readonly SupabaseService _dbService; // Зсилаємося на сервіс бази даних

        public InventoryService(SupabaseService dbService) 
        {
            inventory = new List<Item>();
            _dbService = dbService; 
        }

        public async Task<bool> LoginUserAsync(string email, string password) // Метод для логіну користувача через Supabase Auth
        {
            return await _dbService.LoginAsync(email, password); // Використовуємо метод логіну з SupabaseService і повертаємо результат
        }

        public async Task<bool> RegisterUserAsync(string email, string password)
        {
            return await _dbService.RegisterAsync(email, password);
        }

        public async Task LoadFromDatabaseAsync() // Метод для завантаження даних з бази даних при запуску програми
        {
            inventory = await _dbService.GetAllItemsAsync(); // Заповнюємо invenory даними з бази
        }

        public async Task AddItemAsync(Item item) // Метод для додавання нового товару
        {
            await _dbService.InsertItemAsync(item); // Додаємо товар в БД         

            inventory.Add(item); // Додаємо в локальний список для відображення в таблиці
        }

        public async Task<bool> RemoveItemAsync(int article) // Метод для видалення товару за артикулом
        {
            var item = inventory.FirstOrDefault(i => i.Article == article); // Шукаємо товар у локальному списку

            if (item != null)
            {
                await _dbService.DeleteItemAsync(article); // Якщо товар існує, видаляємо з БД
  
                inventory.Remove(item); // Видаляємо з локального списку
                return true;
            }
            return false;
        }

        public async Task<bool> UpdatePriceAsync(int article, float newPrice) // Метод для оновлення ціни товару за артикулом
        {
           
            var item = inventory.FirstOrDefault(i => i.Article == article); // Шукаємо товар у локальному списку

            if (item != null)
            {
                await _dbService.UpdatePriceAsync(article, newPrice); // Якщо товар є в списку, оновлюємо ціну в хмарній БД

                item.Price = newPrice; // Оновлюємо ціну локально
                return true;
            }
            return false;
        }

        public List<Item> GetItemsSortedByPrice() => inventory.OrderBy(i => i.Price).ToList(); // Метод для отримання списку товарів, відсортованого за ціною
        public List<Item> GetHomelandItems() => inventory.OfType<HomelandItem>().Cast<Item>().ToList(); // Метод для отримання списку товарів вітчизняного виробництва
        public List<Item> GetImportItems() => inventory.OfType<ImportItem>().Cast<Item>().ToList(); // Метод для отримання списку імпортних товарів

        public List<Item> SearchByNameAndCountry(string name, string country) // Метод для пошуку імпортних товарів за назвою та країною виробника
        {
            return inventory.OfType<ImportItem>()
                            .Where(i => i.Title.Contains(name, StringComparison.OrdinalIgnoreCase) && i.ProducerCountry.Equals(country, StringComparison.OrdinalIgnoreCase))
                            .Cast<Item>()
                            .ToList();
        }

        public Item? SearchByArticle(int article) => inventory.FirstOrDefault(i => i.Article == article); // Метод для пошуку товару за артикулом. Повертає null, якщо товар не знайдено
        public List<Item> GetAllItems() => inventory; // Метод для отримання всіх товарів в пам'яті
    }
}

