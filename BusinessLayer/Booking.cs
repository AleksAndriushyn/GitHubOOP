using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Booking
    {
        public string BookItem(string bookGood)
        {
            DataAccessLayer.Shop booking = new DataAccessLayer.Shop();
            return booking.BookItem(bookGood);
        }
    }
}
