﻿namespace Shopping.Client.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal price { get; set; }
    }
}
