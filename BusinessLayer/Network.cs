using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Network
    {
        List<DataAccessLayer.Shop> shops = new List<DataAccessLayer.Shop>();

        public string AddShops(string name)
        {
            foreach (var x in shops)
            {
                if (name == x.name)
                {
                    return name;
                }
            }
            return name;
        }

        public string GetShopByName(string StoreName)
        {
            DataAccessLayer.Shop shop = new DataAccessLayer.Shop();

            if (StoreName == "Electronics")
            {
                shop.AddGood(StoreName);
                return shop.GetGoods(StoreName);
            }
            else if (StoreName == "Apteka")
            {
                shop.AddGood(StoreName);
                return shop.GetGoods(StoreName);
            }
            else if (StoreName == "Store")
            {
                shop.AddGood(StoreName);
                return shop.GetGoods(StoreName);
            }
            else throw new Exception();
        }
    }
}
