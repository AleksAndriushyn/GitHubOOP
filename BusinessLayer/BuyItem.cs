using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BuyItem
    {
        public string Buy_Good(string Good)
        {
            string answer = $"You've bought the {Good}.\n" +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.";
            return answer;
        }
    }
}
