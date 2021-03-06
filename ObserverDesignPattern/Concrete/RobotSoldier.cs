using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Concrete
{
    public class RobotSoldier : ISoldier
    {
        public string name { get; set; }

        public void UpdateStatuse(string order)
        {
            Console.WriteLine("Statüm : " + order);
        }
    }
}
