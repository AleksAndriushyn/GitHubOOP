using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace DataAccessLayer
{
    public class Booking
    {
        public DateTime validity;
        public DateTime date;

        public Booking(DateTime validity, DateTime date)
        {
            this.validity = validity;
            this.date = date;
        }
    }
}
