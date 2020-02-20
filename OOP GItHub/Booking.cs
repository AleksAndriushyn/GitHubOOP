using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_GItHub
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

        static public void BookItem(ListBox listBox, ListBox listBox1)
        {
            Booking booking = new Booking(DateTime.Now.AddDays(7), DateTime.Now);

            string[] text = listBox.SelectedItem.ToString().Split(',');

            MessageBox.Show($"You've booked the {text[1]} {booking.date}.\n" +
                            $"Your booking will expire {booking.validity}.");

            listBox1.Items.Add(listBox.SelectedItem.ToString());

            listBox.Items.Remove(listBox.SelectedItem.ToString());
        }
    }
}
