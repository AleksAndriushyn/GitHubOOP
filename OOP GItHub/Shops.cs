using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GItHub
{
    public partial class Shops : Form
    {
        public Shops()
        {
            InitializeComponent();
        }

        private void Goods_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Recipe_Click(object sender, EventArgs e)
        {

        }

        private void Buy_Click(object sender, EventArgs e)
        {
            Shop buy = new Shop();
            
            MessageBox.Show($"You've bought the {buy.BuyItem(Booked_Goods)}.\n" +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.");

            Booked_Goods.Items.Remove(Booked_Goods.SelectedItem.ToString());
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Goods_List.Items.Add(Booked_Goods.SelectedItem.ToString());
            Booked_Goods.Items.Remove(Booked_Goods.SelectedItem.ToString());
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            Shop buy = new Shop();

            MessageBox.Show($"You've bought the {buy.BuyItem(Goods_List)}.\n" +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.");

            Goods_List.Items.Remove(Goods_List.SelectedItem.ToString());
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            FileDownloader load = new FileDownloader();
            load.LoadFile(txtPath, Goods_List);
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            FileDownloader browse = new FileDownloader();
            browse.BrowseFile(txtPath);
        }

        private void Book_button_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking(DateTime.Now.AddDays(7), DateTime.Now);

            MessageBox.Show($"You've booked the {booking.BookItem(Goods_List, Booked_Goods)} {booking.date}.\n" +
                            $"Your booking will expire {booking.validity}.");

            Booked_Goods.Items.Add(Goods_List.SelectedItem.ToString());
            Goods_List.Items.Remove(Goods_List.SelectedItem.ToString());
        }

        private void Booked_Goods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shops1_Click(object sender, EventArgs e)
        {

        }
    }
}
