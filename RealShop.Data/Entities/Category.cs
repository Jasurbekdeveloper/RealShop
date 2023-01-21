using System.Text.Json.Serialization;

namespace RealShop.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public ICollection< Product>? Products { get; set; }
    }
}