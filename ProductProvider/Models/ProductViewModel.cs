﻿namespace ProductProvider.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
    }
}