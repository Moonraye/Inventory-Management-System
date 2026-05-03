using Postgrest.Attributes;
using Postgrest.Models;
using System;

namespace Inventory_Manager.Model
{
    [Table("items")]
    public class SupabaseItem : BaseModel
    {
        [PrimaryKey("id", false)] // false означає, що id генерується на стороні БД, тобто в supabase
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; } = string.Empty; 

        [Column("article")]
        public int Article { get; set; }

        [Column("count")]
        public int Count { get; set; }

        [Column("delivered_at")]
        public DateTime DeliveredAt { get; set; }

        [Column("expiration_date")]
        public DateTime ExpirationDate { get; set; }

        [Column("price")]
        public float Price { get; set; }

        [Column("category")]
        public int Category { get; set; }

        [Column("item_type")]
        public string ItemType { get; set; } = string.Empty; // Homeland або Import

        [Column("producer_country")]
        public string? ProducerCountry { get; set; } // Nullable (?), оскільки для Homeland це поле не використовується
    }
}