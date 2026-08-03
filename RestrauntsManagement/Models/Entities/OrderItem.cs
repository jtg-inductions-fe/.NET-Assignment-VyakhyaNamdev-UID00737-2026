using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetRestaurantManagement.Models.Entities
{
    [Table("OrderedItems")]
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public long MenuItemId { get; set; }

        public long OrderId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(1, int.MaxValue)]
        public decimal Price { get; set; }

        [ForeignKey(nameof(MenuItemId))]
        public virtual MenuItem MenuItem { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }
    }
}