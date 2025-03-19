using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Item
    {
        int id;
        int weight;
        int value;
        int ratio;

        public Item(int weight, int value, int id)
        {
            this.weight = weight;
            this.value = value;
            this.id = id;
            this.ratio = value/weight;
        }

        public int getWeight() { return weight; }
        public int getValue() { return value; }

        


    }
}
