using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInventory.Models
{
    internal class ProductModel
    {
        private Product product = new Product();

        public void setName(string name)
        {
            this.product.name = name;
        }

        public string getName()
        {
            return this.product.name;
        }

        public void setId(int id)
        {
            this.product.id = id;
        }
        public int getId()
        {
            return this.product.id;
        }

        public void setAmount(double amount)
        {
            this.product.amount = amount;
        }

        public double getAmount()
        {
            return this.product.amount;
        }

        public void setPrice(decimal price)
        {
            this.product.price = price;
        }

        public decimal getPrice()
        {
            return this.product.price;
        }
    }
}
