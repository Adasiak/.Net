using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm
{
    public partial class BackpackForm : Form
    {
        public BackpackForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            int k = int.Parse(textBox2.Text);
            int capacity = int.Parse(textBox1.Text);
            Random rnd = new Random();
            List<Item> list = new List<Item>();
            for (int j = 0; j < k; j++)
            {
                list.Add(new Item(j, rnd.Next(1, 40), rnd.Next(1, 40)));
            }
            foreach (Item item in list)
            {
                listBox1.Items.Add("Item " + item.GetIndex() + ": Weight " + item.GetWeight() + " Value " + item.GetValue() + " Ratio " + item.GetRatio());
            }
            List<Item> sortedList = list.OrderByDescending(o => o.GetRatio()).ToList();
            foreach (Item item in sortedList)
            {
                listBox2.Items.Add("Item " + item.GetIndex() + ": Weight " + item.GetWeight() + " Value " + item.GetValue() + " Ratio " + item.GetRatio());
            }
            Backpack1 backpack = new Backpack1(capacity);
            backpack.getElement(sortedList);

            foreach (Item item in backpack.getItemsinBackpack())
            {
                listBox3.Items.Add("Item " + item.GetIndex() + " Weight  " + item.GetWeight() + " Value " + item.GetValue());

            }
            listBox4.Items.Add("Total weight: " + backpack.getTotalWeight() + " Total value: " + backpack.getTotalValue());
        }
    }
}
