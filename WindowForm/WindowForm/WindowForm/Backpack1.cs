using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForm
{
    public class Backpack1
    {
        int capacity;
        int total_weight;
        int total_value;
        List<Item> itemsInBackPack;
        public Backpack1(int capacity)
        {
            this.capacity = capacity;
            this.itemsInBackPack = new List<Item>();
            this.total_weight = 0;
            this.total_value = 0;
        }
        public void getElement(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.GetWeight() < capacity)
                {
                    this.itemsInBackPack.Add(item);
                    this.capacity -= item.GetWeight();
                    this.total_weight += item.GetWeight();
                    this.total_value += item.GetValue();
                }
            }

        }
        public List<Item> getItemsinBackpack()
        {
            return this.itemsInBackPack;
        }
        public int getTotalWeight()
        {
            return this.total_weight;
        }
        public int getTotalValue()
        {
            return this.total_value;
        }
    }
}
