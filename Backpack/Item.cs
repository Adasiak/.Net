using System.Runtime.InteropServices;
using System;

namespace Backpack
{
    public class Item
    {
        int value;
        int weight;
        double ratio;
        public Item(int value, int weight)
        {
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
    }

}
