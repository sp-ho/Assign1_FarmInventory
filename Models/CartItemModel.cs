using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInventory.Models
{
    internal class CartItemModel
    {
        private CartItem cartItem = new CartItem();

        public void setProductName(string name)
        {
            this.cartItem.productName = name;
        }

        public string getProductName()
        {
            return this.cartItem.productName;
        }

        public void setAmountPurchased(double amountPurchased)
        {
            this.cartItem.amountPurchased = amountPurchased;
        }

        public double getAmountPurchased()
        {
            return this.cartItem.amountPurchased;
        }

        public void setPricePerKg(decimal pricePerKg) 
        {
            this.cartItem.pricePerKg = pricePerKg;
        }

        public decimal getPricePerKg()
        {
            return this.cartItem.pricePerKg;
        }
    }
}
