using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wordli
{
    internal class levele2:levele
    {
        public override string Getword()
        {
            string[] words = File.ReadAllLines(@"C:\\word.txt");
            Random ind = new Random();
        Ert:
            int N = ind.Next(21);
            if (words[N].Length == 5)
                return words[N].ToString();
            else goto Ert;
        }
    }
}
