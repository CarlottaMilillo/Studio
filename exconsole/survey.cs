using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exconsole
{
    class survey

    {
        /// <summary>
        /// class to store answered questions
        /// </summary>
        public class Answers
        {

            public string name { get; set; }
            public int age { get; set; }
            public string month { get; set; }
        }
        /// <summary>
        /// entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Answers> ans = new List<Answers>();

            Console.WriteLine("Here's a few questions for you:\n");
            //adding to the list a new implemented class with new values 
            ans.Add(new Answers
            {
                name = Ask("1. What is your name?\n"),
                age = int.Parse(Ask("1. How old are you?\n")),
                month = Ask("1. What month are you born in?\n")
            });

            foreach (Answers s in ans)
            {
                Console.WriteLine("Name: {0}\n" +
                                  "Age: {1}\n" +
                                  "Month: {2}\n", s.name, s.age, s.month);

            }


        }
        /// <summary>
        /// class to ask questions and getting answers in var 
        /// </summary>
        /// <param name="question"> string question </param>
        /// <returns> an aske question with answer </returns>
        public static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

    }

}
