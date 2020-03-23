using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace OOP_GItHub
{
    static class MainFile
    {
        [STAThread]
        static void Main()
        {
            MessageBox.Show(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Shops());
        }
    }
}
