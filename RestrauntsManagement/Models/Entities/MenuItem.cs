using DotNetRestaurantManagement.Models.Enums;
using DotNetRestaurantManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetRestaurantManagement.Models.Entities
{
    [Table("MenuItems")]
    public class MenuItem
    {
        public MenuItem()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        public long Id { get; set; }
        public long RestaurantId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int PreparationTime { get; set; }

        public MenuCategory Category { get; set; }

        [Range(0, int.MaxValue)]
        public int QuantityAvailable { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}