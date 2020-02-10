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
        Booking booking = new Booking(DateTime.Now.AddDays(7), DateTime.Now);

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
            string selectedGood = Booked_Goods.SelectedItem.ToString();

            MessageBox.Show($"You've bought the {selectedGood}.\n" +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.");

            Booked_Goods.Items.Remove(selectedGood);
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string selectedGood = Booked_Goods.SelectedItem.ToString();

            Booked_Goods.Items.Remove(selectedGood);

            Goods_List.Items.Add(selectedGood);
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            string selectedGood = Goods_List.SelectedItem.ToString();

            MessageBox.Show($"You've bought the {selectedGood}.\n" +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.");

            Goods_List.Items.Remove(selectedGood);
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(txtPath.Text.Trim());

                foreach (string line in lines)
                    Goods_List.Items.Add(line);
            }

            catch { }
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                if (op.ShowDialog() == DialogResult.OK)
                    txtPath.Text = op.FileName;
            }

            catch { }
        }

        private void Book_button_Click(object sender, EventArgs e)
        {
            Good g = new Good();

            string[] strs = Goods_List.SelectedItem.ToString().Split(',');

            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = strs[i].Replace(" ", "");
            }

            if (strs.Length == 5)
            {
                g = new Good(int.Parse(strs[0]), strs[1], int.Parse(strs[2]), bool.Parse(strs[3]));
            }

            if (g is Good)
            {
                string selectedGood = Goods_List.SelectedItem.ToString();

                MessageBox.Show($"You've booked the {g.name} {booking.date}.\n" +
                                $"Your booking will expire {booking.validity}.");

                Booked_Goods.Items.Add(selectedGood);

                Goods_List.Items.Remove(selectedGood);
            }
        }
    }
}
