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
    class Shop
    {
        static public void BuyItem(ListBox listBox)
        {
            string[] text = listBox.SelectedItem.ToString().Split(',');

            MessageBox.Show($"You've bought the {text[1]}.\n" +
                    $"\nCome to the store from Monday-Friday from 9:00 to 21:00.");

            listBox.Items.Remove(listBox.SelectedItem.ToString());
        }

        static public void DeleteItem(ListBox listBox, ListBox listBox1)
        {
            listBox1.Items.Add(listBox.SelectedItem.ToString());
            listBox.Items.Remove(listBox.SelectedItem.ToString());
        }
    }
}
    

