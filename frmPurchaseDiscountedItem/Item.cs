using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itemnamespace
{
    internal abstract class Item
    {

        protected int Quantity;
        protected double Total_Price;
        protected double item_price;
        protected string item_name;

        public abstract double getTotalPrice();
        public abstract double getChange();

        public abstract void setPayment(double amount);


    }
}