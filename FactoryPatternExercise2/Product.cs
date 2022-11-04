using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public static List<Product> products = new List<Product>()
        {
            new Product() {Name = "Pogo Stick", Price = 25.00},
            new Product() {Name = "SkateBoard", Price = 35.00},
            new Product() {Name = "Slinky", Price = 5.00}
        };
    }
}

