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
            int age = int.Parse(Console.ReadLine());

                if (age >= 18)
            {
                Console.WriteLine("You are an adult.");

            }
                else
            {
                if (age == 16)
                {
                    Console.WriteLine("You can drive.");
                }

                else
                {
                    if (age == 17)
                    {
                        Console.WriteLine("You can drive.");
                    }
                    else
                    {
                        if (age <=15)
                        {
                            Console.WriteLine("You're not an adult");
                        }
                    }
                }
            }

          
            }
        }
    }

