using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Abstract
{
    public interface ISoldier
    {
        public string name { get; set; }
        public void UpdateStatuse(string order); 
    }
}
