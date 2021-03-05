using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern.Concrete
{
    public class ExchangeOrder
    {
       public int orderCount;
        public ExchangeOrder(int orderCount)
        {
            this.orderCount = orderCount;
        }
    }
}
