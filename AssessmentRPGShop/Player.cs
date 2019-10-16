using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop3
{
    class Player
    {
        int InventoryCount = 0;
        public Item[] Inventory = new Item[10];
        public float gold = 0.00f;
        public void buy(Item a)
        {
            if(gold > a.cost)
            {
                gold -= a.cost;
                Inventory[InventoryCount] = a;
            }
        }
        public void sell(Item a)
        {
            gold += a.cost;
        }
    }
}
