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
            int i = 1;
            int k = 15;
            Random rnd = new Random();
            List<Item> list = new List<Item>();
            for (int j = 0; j < k; j++)
            {
                list.Add(new Item(rnd.Next(1,100), rnd.Next(1, 100)));
            }


            List<Item> sortedList = list.OrderByDescending(o=>o.GetRatio()).ToList();
            foreach(Item item in sortedList)
            {
                Console.WriteLine(item.GetRatio());
            }
            Backpack1 backpack = new Backpack1(60);
            backpack.getElement(sortedList);
            
            foreach (Item item in backpack.getItemsinBackpack())
            {
                Console.WriteLine("Item " + i + ": " + item.GetValue() + " " + item.GetWeight());
                i = i + 1;
            }

            System.Console.Read();
        }
    }
}
