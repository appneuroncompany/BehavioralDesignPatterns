using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Concrete
{
    public class General
    {
        List<ISoldier> soldiers;

        private string order;

        public string Order
        {
            get { return order; }
            set { order = value;
                GiveOrder(value);
            }
        }


        public General()
        {
            soldiers = new List<ISoldier>();
        }

        public void AddSoldier(ISoldier soldier)
        {
            soldiers.Add(soldier);
        }

        void GiveOrder(string order)
        {
            foreach (var soldier in soldiers)
            {
                soldier.UpdateStatuse(order);
            }
        }
    }
}
