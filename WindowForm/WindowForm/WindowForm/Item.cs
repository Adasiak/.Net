using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForm
{
    public class Item
    {
        int item_index;
        int value;
        int weight;
        double ratio;
        public Item(int item_index, int value, int weight)
        {
            this.item_index = item_index;
            this.value = value;
            this.weight = weight;
            this.ratio = Decimal.ToDouble(value) / Decimal.ToDouble(weight);

        }
        public double GetRatio()
        {
            return this.ratio;
        }
        public int GetWeight()
        {
            return this.weight;
        }
        public int GetValue()
        {
            return this.value;
        }
        public int GetIndex()
        {
            return this.item_index;
        }
    }
}
