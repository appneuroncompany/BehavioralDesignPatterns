using ChainOfResponsibilityDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern.Abstract
{
    public interface IExchangeOfficer
    {
        public string Name { get; set; }
        void ExchangeProccess(ExchangeOrder order);
    }
}
