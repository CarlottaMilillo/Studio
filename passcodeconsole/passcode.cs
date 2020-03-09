using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passcodeconsole
{
    class passcode
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your passcode:");
            var psw = Console.ReadLine();
            if (psw == "secret")
            {
                Console.WriteLine("You shall pass.");
            }
            else
            {
                Console.WriteLine("You shall not pass, please try again.");
            }

        }
    }
}
