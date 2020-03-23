using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessLayer
{
    public class FileDownloader
    {
        public Good AddElectronics(List<Good> someList)
        {
            string filePath = @"d:\\Мои документы\Документы\ООП\Лаба 3\goodsElectronics.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                someList.Add(new Good(Int32.Parse(entries[0]), entries[1], Int32.Parse(entries[2]), Boolean.Parse(entries[3])));
            }
            return someList[1];
        }

        public Good AddApteka(List<Good> someList)
        {
            string filePath = @"d:\\Мои документы\Документы\ООП\Лаба 3\goodsApteka.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                someList.Add(new Good(Int32.Parse(entries[0]), entries[1], Int32.Parse(entries[2]), Boolean.Parse(entries[3])));
            }
            return someList[1];
        }

        public Good AddStore(List<Good> someList)
        {
            string filePath = @"d:\\Мои документы\Документы\ООП\Лаба 3\goodsStore.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                someList.Add(new Good(Int32.Parse(entries[0]), entries[1], Int32.Parse(entries[2]), Boolean.Parse(entries[3])));
            }
            return someList[1];
        }
    }
}
