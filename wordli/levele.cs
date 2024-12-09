using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordli
{
    abstract class levele
    {
       public List<System.Windows.Forms.TextBox> listtext = new List<System.Windows.Forms.TextBox>();
        public abstract string Getword();


    }
}
