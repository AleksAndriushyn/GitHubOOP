using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GItHub
{
    class Shop
    {
        public int id;

        public string name;

        public List<Good> goods = new List<Good>();

        FileDownloader file = new FileDownloader();

        public Shop(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void AddGood(string storeName)
        {
            if (storeName == "Electronics")
            {
                file.AddElectronics(goods);
            }

            else if (storeName == "Apteka")
            {
                file.AddApteka(goods);
            }

            else if (storeName == "Store")
            {
                file.AddStore(goods);
            }
        }

        public void AddGoods(List<Good> newList)
        {
            goods = newList;
        }

        public string GetGoods(string storeName)
        {
            string allGoods = "";

            if (storeName == "Electronics")
            {
                foreach (var x in goods)
                {
                    allGoods += "\nName: " + x.name + ", Price: " + x.price + ", Amount: " + ".\n";
                }
                return allGoods;
            }

            else if (storeName == "Apteka")
            {
                foreach (var x in goods)
                {
                    allGoods += "\nName: " + x.name + ", Price: " + x.price + ", Amount: " + ".\n";

                }
                return allGoods;
            }

            else if (storeName == "Store")
            {
                foreach (var x in goods)
                {
                    allGoods += "\nName: " + x.name + ", Price: " + x.price + ", Amount: " + ".\n";
                }
                return allGoods;
            }
            return allGoods;
        }

        public void GetGoodsByName(string goodsName)
        {
            foreach (var x in goods)
            {
                if (goodsName == x.name)
                {
                    BookItem(goodsName);
                }
            }
        }

        public string BookItem(string bookGood)
        {
            Booking booking = new Booking(DateTime.Now.AddDays(7), DateTime.Now);

            string answer = "";

            if (bookGood == "Yes")
            {
                answer = $"You've booked the good {booking.date}.\n" +
                    $"Your booking will expire {booking.validity}." +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.";
                return answer;
            }

            else if (bookGood == "No")
            {
                answer = "Ok, then come to the store today from 9:00 to 21:00." +
                    "\nThank you for buying!";
                return answer;
            }

            else throw new FormatException("Wrong answer");
        }
    }
}
