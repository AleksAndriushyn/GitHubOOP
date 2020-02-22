using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace OOP_GItHub
{
    class FileDownloader
    {
        public void LoadFile(TextBox textBox, ListBox listBox)
        {
            try
            {
                string[] lines = File.ReadAllLines(textBox.Text.Trim());

                foreach (string line in lines)
                    listBox.Items.Add(line);
            }

            catch { }
        }

        public void BrowseFile(TextBox textBox)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                if (op.ShowDialog() == DialogResult.OK)
                    textBox.Text = op.FileName;
            }

            catch { }
        }
    }
}
