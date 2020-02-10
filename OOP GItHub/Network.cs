using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GItHub
{
    class Network
    {
        List<Shop> shops = new List<Shop>();

        public void AddShop()
        {
            shops.Add(new Shop(122500, "Store"));
            shops.Add(new Shop(532689, "Apteka"));
            shops.Add(new Shop(936557, "Electronics"));
        }

        public string GetShopByName(string storeName)
        {
            foreach (var y in shops)
            {
                if (storeName == y.name)
                {
                    Shop shop = new Shop(y.id, y.name);
                    shop.AddGood(storeName);
                    return shop.GetGoods(storeName);
                }
            }
            throw new FormatException("Wrong store name");
        }
    }
}
