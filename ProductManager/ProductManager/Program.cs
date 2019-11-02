using System;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager!");
            int i1 = GetInt("Enter a whole number: ");
            Console.WriteLine("i1 = " + i1);

            string name = "";
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();



            Console.WriteLine("Goodbye");
        }


        private static void printThreeNumbers(int a, int b, int c)
        {
            Console.WriteLine(a + ", " + b + ", " + c);
        }


        private static int GetInt(string prompt){
            int i = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                string s = Console.ReadLine();
                if (int.TryParse(s, out i))
                {
                    success = true;
                }
                else
                {
                    Console.WriteLine("Error - not a whole number: " + s);
                }
               

                }

                return i;


            }
        }
    }


