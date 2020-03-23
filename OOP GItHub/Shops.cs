using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OOP_GItHub
{
    public partial class Shops : Form
    {
        BusinessLayer.LoadGoods bl = new BusinessLayer.LoadGoods();
        BusinessLayer.BuyItem buy = new BusinessLayer.BuyItem();
        BusinessLayer.Network network = new BusinessLayer.Network();

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
            MessageBox.Show($"{buy.Buy_Good(Booked_Goods.SelectedItem.ToString())}");
            Booked_Goods.Items.Remove(Booked_Goods.SelectedItem.ToString());
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Goods_List.Items.Add(Booked_Goods.SelectedItem.ToString());
            Booked_Goods.Items.Remove(Booked_Goods.SelectedItem.ToString());
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{buy.Buy_Good(Shop_List.SelectedItem.ToString())}");
            Goods_List.Items.Remove(Goods_List.SelectedItem.ToString());
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            Goods_List.Items.Add(bl.GetGoods_List(Shop_List.SelectedItem.ToString()));
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            Shop_List.Items.Add(network.AddShops(txtPath.Text.Trim().ToString()));
        }

        private void Book_button_Click(object sender, EventArgs e)
        {
            BusinessLayer.Booking booking = new BusinessLayer.Booking();

            MessageBox.Show(booking.BookItem(Goods_List.SelectedItem.ToString()));

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
