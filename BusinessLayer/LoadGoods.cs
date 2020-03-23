using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BusinessLayer
{
    public class LoadGoods
    {
        public string GetGoods_List(string StoreName)
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
            else if(StoreName == "Store")
            {
                shop.AddGood(StoreName);
                return shop.GetGoods(StoreName);
            }
            else throw new Exception();
        }
    }
}
