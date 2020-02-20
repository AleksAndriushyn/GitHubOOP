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
            Shop.BuyItem(Booked_Goods);
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Shop.DeleteItem(Booked_Goods, Goods_List);
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            Shop.BuyItem(Goods_List);
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            FileDownloader.LoadFile(txtPath, Goods_List);
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            FileDownloader.BrowseFile(txtPath);
        }

        private void Book_button_Click(object sender, EventArgs e)
        {
            Booking.BookItem(Goods_List, Booked_Goods);            
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
