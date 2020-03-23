using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Network
    {
        public string AddShops(string name)
        {
            List<DataAccessLayer.Shop> shops = new List<DataAccessLayer.Shop>();

            foreach (var x in shops)
            {
                if (name == x.name)
                {
                    return name;
                }
            }
            return name;
        }
    }
}
