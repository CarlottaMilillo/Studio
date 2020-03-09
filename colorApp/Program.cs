using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colorApp
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("select a color:");
            Console.ReadLine();
            Console.WriteLine("the color is: {0}", colore);
        }

    }
    public class Color
    {
        public enum palette
        {
            black = 0x000000,
            red = 0xFF0000,
            yellow = 0xFFFF00,
            green = 0x008000,
            blue = 0x0000FF,
            purple = 0x800080,
            pink = 0xFF00FF,
            white = 0xFFFFFF,
            olive = 0x808000,
            teal = 0x008080,
            gray = 0x808080,
            aqua = 0x00FFFF,
            maroon = 0x800000


        }
    }
}


