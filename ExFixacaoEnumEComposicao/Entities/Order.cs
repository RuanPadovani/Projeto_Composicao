using System;
using System.Collections.Generic;
using ExFixacaoEnumEComposicao.Entities.Enums;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace ExFixacaoEnumEComposicao.Entities
{
    class Order
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public OrderItem OrderItem { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(Client client, OrderStatus status) 
        {
            Client = client;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);

        }

        public void RemoveItem(OrderItem item) 
        { 
            Items.Remove(item); 
        }

        public double Total() 
        {
            double sum = 0;

            foreach (OrderItem item in Items) 
            {
                sum += item.SubTotal();

            }
        
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy") + ") - " + Client.Email);
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name
                    + ", $" + item.Price.ToString("F2")
                    + ", Quantity: " + item.Quantity
                    + ", Subtotal: $" + item.SubTotal().ToString("F2"));
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2"));

            return sb.ToString();
        }

    }
}
