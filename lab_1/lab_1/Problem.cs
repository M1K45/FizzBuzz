using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab_1
{
    class Problem
    {
        int numItems;
        List <Item> items;

        int minValue = 1;
        int maxValue = 10;
        
        public Problem (int n, int seed)
        {
            items = new List <Item> ();
            this.numItems = n;
            Random random = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                Item a = new Item(random.Next(maxValue), random.Next(maxValue), i);
                items.Add(a);

            }      
        }

        public override string ToString()
        {
            string text = string.Empty;
           foreach (Item a in items)
            {
                text += ("Weight: " + a.getWeight().ToString() + " Value: " + a.getValue().ToString() + "\n");
            } 
           return text;
        }

       
        Result Solve() { 
            Result result = new Result();
            items.Sort();
            
            return result;

        }

        


    }
}
