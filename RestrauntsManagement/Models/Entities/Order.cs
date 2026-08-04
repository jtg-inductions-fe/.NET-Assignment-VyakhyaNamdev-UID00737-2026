using DotNetRestaurantManagement.Models.Enums;
using DotNetRestaurantManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetRestaurantManagement.Models.Entities
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            OrderedItems = new HashSet<OrderItem>();
        }

        [Key]
        public long Id { get; set; }

        public long RestaurantId { get; set; }

        public long CustomerId { get; set; }

        public long DeliveryAddressId { get; set; }

        [Range(1, long.MaxValue)]
        public long TotalItems { get; set; }

        [Range(0, int.MaxValue)]
        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime PlacedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeliveredAt { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        public virtual Restaurant Restaurant { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public virtual User Customer { get; set; }

        [ForeignKey(nameof(DeliveryAddressId))]
        public virtual Address DeliveryAddress { get; set; }

        public virtual ICollection<OrderItem> OrderedItems { get; set; }
    }
}