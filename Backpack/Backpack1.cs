using System.Collections.Generic;
using System.Linq;

namespace Backpack
{
    public class Backpack1
    {
        int capacity;
        List<Item> itemsInBackPack;
        public Backpack1(int capacity) 
        {
            this.capacity = capacity;
            this.itemsInBackPack = new List<Item>();
        }
        public void getElement(List<Item> items)
        {
            foreach(Item item in items)
            {
                if(item.GetWeight() < capacity)
                {
                    this.itemsInBackPack.Add(item);
                    this.capacity = this.capacity -  item.GetWeight();
                }
            }

        }
        public List<Item> getItemsinBackpack()
        {
            return this.itemsInBackPack;
        }
    }
}