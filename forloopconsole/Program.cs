using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int v = 1; v <= 5; v++)
            {

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
