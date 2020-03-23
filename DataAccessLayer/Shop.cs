using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Shop
    {
        public int id;
        public string name;
        public List<Good> goods = new List<Good>();
        public FileDownloader file = new FileDownloader();

        public Shop() { }

        public Shop(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string AddGood(string storeName)
        {
            if (storeName == "Electronics")
            {
                return file.AddElectronics(goods).ToString();
            }

            else if (storeName == "Apteka")
            {
                return file.AddApteka(goods).ToString();
            }

            else if (storeName == "Store")
            {
                return file.AddStore(goods).ToString();
            }
            else throw new Exception();
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
                    allGoods += "Name: " + x.name + ", Price: " + x.price + ", Availability: " + x.availbl + ".";
                }
                return allGoods;
            }

            else if (storeName == "Apteka")
            {
                foreach (var x in goods)
                {
                    allGoods += "Name: " + x.name + ", Price: " + x.price + ", Availability: " + x.availbl + ".";
                }
                return allGoods;
            }

            else if (storeName == "Store")
            {
                foreach (var x in goods)
                {
                    allGoods += "Name: " + x.name + ", Price: " + x.price + ", Availability: " + x.availbl + ".";
                }
                return allGoods;
            }
            return allGoods;
        }

        public string BookItem(string bookGood)
        {
            Booking booking = new Booking(DateTime.Now.AddDays(7), DateTime.Now);
            Good good = new Good();

            string answer = $"You've booked the {bookGood} {booking.date}.\n" +
                    $"Your booking will expire {booking.validity}." +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.";

            return answer;
        }
    }
}
