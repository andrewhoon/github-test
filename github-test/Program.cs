using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int score = int.Parse(Console.ReadLine());

                if (score <= 16)
            {
                Console.WriteLine("Sorry, you are not old enough to see this movie.");

            }
                else
            {
                Console.WriteLine("Congrats on your age, you may proceed to view this movie.");
            }

            
        
        }
    }
}
