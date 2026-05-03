using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager.Model
{
    public abstract class Item // Абстрактний клас для товарів
    {
        public string Title { get; set; }
        public int Article { get; set; }
        public int Count { get; set; }
        public DateTime DeliveredAt { get; set; }
        public DateTime ExpirationDate { get; set; }
        public float Price { get; set; }
        public int Category { get; set; }

        public abstract string ItemType { get; }

        protected Item(string title, int article, int count, DateTime deliveredAt, DateTime expirationDate, float price, int category) // Конструктор з властивостями item
        {
            Title = title;
            Article = article;
            Count = count;
            DeliveredAt = deliveredAt;
            ExpirationDate = expirationDate;
            Price = price;
            Category = category;
        }
        public virtual float CalculateRemainItemsPrice() // Віртуальний метод для розрахунку вартості залишкових товарів
        {
            return Count * Price;
        }
    }
    public class HomelandItem : Item // Клас для товарів вітчизняного виробництва, наслідується від Item
    {
        public override string ItemType => "Homeland";

        public HomelandItem(string title, int article, int count, DateTime deliveredAt, DateTime expirationDate, float price, int category) 
            : base(title, article, count, deliveredAt, expirationDate, price, category) 
        {
        } 

        public override float CalculateRemainItemsPrice()
        {
            return Count * Price;
        }
    }
    public class ImportItem : Item // Клас для імпортних товарів, наслідується від Item
    {
        public override string ItemType => "Import";

        public string ProducerCountry { get; set; }

        public ImportItem(string title, string producerCountry, int article, int count, DateTime deliveredAt, DateTime expirationDate, float price, int category)
            : base(title, article, count, deliveredAt, expirationDate, price, category)
        {
            ProducerCountry = producerCountry;
        }

        public float CountPriceWithDelivery() // Метод для розрахунку вартості товару з урахуванням доставки
        {
            return Price * 1.05f;
        }

        public override float CalculateRemainItemsPrice() // Перевизначений метод для розрахунку вартості залишкових імпортних товарів з урахуванням доставки
        {
            return Count * CountPriceWithDelivery();
        }
    }
}
