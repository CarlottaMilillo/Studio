using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestMessagebox
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("ABC", "DEF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
