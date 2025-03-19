using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Result
    {
        public List<int> itemsId;  
        public int totalWeight;
        public int totalValue;

        public Result()
        {
            itemsId = new List<int>();
            totalWeight = 0;
            totalValue = 0;
        }
        public override string ToString()
        {
            string combinedlist = string.Join(", ", itemsId) + "\n";
            combinedlist += "Total value: " + totalValue + "\n";
            combinedlist += "Total weight: " + totalWeight;
            return combinedlist;
          
        }

    }
}
