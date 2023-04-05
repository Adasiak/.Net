using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using WindowForm;


namespace Testy_Lab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckListCount()
        {
            List<Item> list = new List<Item>();
            Random rnd = new Random();
            for (int j = 0; j < 10; j++)
            {
                list.Add(new Item(j, rnd.Next(1,40) , rnd.Next(1, 40)));
            }
            Assert.AreEqual(10,list.Count);
        }

        [TestMethod]
        public void CheckItemRatio()
        {
            List<Item> list = new List<Item>();
            int k = 10;
            int z = 5;
            for (int j = 0; j < 10; j++)
            {
                list.Add(new Item(j, k, z));
            }

            foreach (Item item in list)
            {
                Assert.AreEqual(2, item.GetRatio());
            }
        }

        [TestMethod]
        public void CheckBackpackTotalWeight()
        {
            List<Item> list = new List<Item>();
            int k = 10;
            int z = 5;
            for (int j = 0; j < 2; j++)
            {
                list.Add(new Item(j, k, z));
            }
            Backpack1 backpack = new Backpack1(60);
            backpack.getElement(list);
            Assert.AreEqual(10,backpack.getTotalWeight());
        }

        [TestMethod]
        public void CheckBacpackTotalValue()
        {
            List<Item> list = new List<Item>();
            int k = 10;
            int z = 5;
            for (int j = 0; j < 2; j++)
            {
                list.Add(new Item(j, k, z));
            }
            Backpack1 backpack = new Backpack1(60);
            backpack.getElement(list);
            Assert.AreEqual(20, backpack.getTotalValue());
        }

        [TestMethod]
        public void CheckItemsInBackpack()
        {
            List<Item> list = new List<Item>();
            int k = 10;
            int z = 5;
            for (int j = 0; j < 10; j++)
            {
                list.Add(new Item(j, k, z));
            }
            Backpack1 backpack = new Backpack1(20);
            backpack.getElement(list);
            Assert.AreEqual(4, backpack.getItemsinBackpack().Count);
        }

        [TestMethod]
        public void CheckBackpackCapacityLeft()
        {
            List<Item> list = new List<Item>();
            int k = 10;
            int z = 5;
            for (int j = 0; j < 4; j++)
            {
                list.Add(new Item(j, k, z));
            }
            Backpack1 backpack = new Backpack1(30);
            backpack.getElement(list);
            Assert.AreEqual(10, backpack.getCapacity());
        }


        [TestMethod]
        public void CheckListCountNotNull()
        {
            List<Item> list = new List<Item>();
            Random rnd = new Random();
            for (int j = 0; j < 10; j++)
            {
                list.Add(new Item(j, rnd.Next(1,40) , rnd.Next(1, 40)));
            }
            Assert.IsNotNull(list.Count);
            

        }

        [TestMethod]
        public void CheckItemRatioNot()
        {
            List<Item> list = new List<Item>();
            int k = 10;
            int z = 5;
            for (int j = 0; j < 10; j++)
            {
                list.Add(new Item(j, k, z));
            }

            foreach (Item item in list)
            {
                Assert.AreNotEqual(15, item.GetRatio());
            }

        }

        [TestMethod]
        public void CheckBackpackTotalWeightIsTrue()
        {
            List<Item> list = new List<Item>();
            int k = 10;
            int z = 5;
            for (int j = 0; j < 2; j++)
            {
                list.Add(new Item(j, k, z));
            }
            Backpack1 backpack = new Backpack1(60);
            backpack.getElement(list);
            Assert.IsFalse(60 == backpack.getTotalWeight());

        }
       
    }   
}
