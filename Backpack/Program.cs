using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Backpack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 15;
            int capacity = 60;
            Random rnd = new Random();
            List<Item> list = new List<Item>();
            for (int j = 0; j < k; j++)
            {
                list.Add(new Item(j,rnd.Next(1,40), rnd.Next(1, 40)));
            }
            Console.WriteLine("Normal List: " );
            foreach(Item item in list) 
            { 
                Console.WriteLine("Item " + item.GetIndex() +": Weight " + item.GetWeight() + " Value " + item.GetValue() + " Ratio " + item.GetRatio());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sorted List:");

            List<Item> sortedList = list.OrderByDescending(o=>o.GetRatio()).ToList();
            foreach(Item item in sortedList)
            {
                Console.WriteLine("Item " + item.GetIndex() + ": Weight " + item.GetWeight() + " Value " + item.GetValue() + " Ratio " + item.GetRatio());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Elements in Backpack of capacity " + capacity + ": ");
            Backpack1 backpack = new Backpack1(capacity);
            backpack.getElement(sortedList);
            
            foreach (Item item in backpack.getItemsinBackpack())
            {
                Console.WriteLine("Item " + item.GetIndex() + " Weight  " + item.GetWeight() + " Value " + item.GetValue());
                
            }
            Console.WriteLine("Total weight: " + backpack.getTotalWeight() + " Total value: " + backpack.getTotalValue());

            System.Console.Read();
        }
    }
}
