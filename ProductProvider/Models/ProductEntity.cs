﻿using System.ComponentModel.DataAnnotations;

namespace ProductProvider.Models
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; } = null!;
        [Required]
        public string Model { get; set; } = null!;
        public string? Description { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be lower than 0.")]
        [Required]
        public decimal Price { get; set; }
        public string? Category { get; set; }
        [Required]
        public string Image { get; set; } = null!;
        [Required]
        public int Stock { get; set; }
        public string? Size { get; set; }
        public DateOnly AddedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}