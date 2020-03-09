using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsconsole
{
    class studenti
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many students per class?");
            var numberstudents = int.Parse(Console.ReadLine());
            var studenti = new int[numberstudents];
            var studentsname = new string[numberstudents];
            var studentgrade = new int[numberstudents]; //treated as a string 
            for (int i = 0; i < numberstudents; i++)
            {

                Console.WriteLine("Please enter the student name : \n");
                studentsname[i] = Console.ReadLine();
                studentsname[i] = IfEmptyString(studentsname[i]);
                Console.WriteLine("Please enter the student grade : \n");
                studentgrade[i] = int.Parse(Console.ReadLine()); //coversion from string to int for the grade 
            
            }
            for (int i = 0; i < numberstudents; i++) //for each of the contined values of the array show the inserted ones 
            {
                Console.WriteLine("Student Name: {0}, Student Grade {1}", studentsname[i], studentgrade[i]);
               
            }

            Console.ReadKey(); //blocks the program in debug , not needed in release
        }
        /// <summary>
        /// if the user doesnt type anything but presses enter 
        /// </summary>
        /// <param name="answer"> the line they have to fill</param>
        /// <returns> the filled string</returns>
        static string IfEmptyString(string answer)
        {
            if (answer == "")
            {
                Console.WriteLine("You have to type something, please try again.");
                return Console.ReadLine();
            }
            return answer;
        }
      


    }
}
