﻿using System.ComponentModel.DataAnnotations;

namespace SM.Infrastructure.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string SerialNumber { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
