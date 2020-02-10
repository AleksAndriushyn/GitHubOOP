using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GItHub
{
    public class Booking
    {
        public DateTime validity;
        public DateTime date;

        public Booking(DateTime validity, DateTime date)
        {
            this.date = date;
            this.validity = validity;
        }
    }
}
