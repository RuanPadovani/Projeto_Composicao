using System;

namespace ExFixacaoEnumEComposicao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() 
        { 
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
