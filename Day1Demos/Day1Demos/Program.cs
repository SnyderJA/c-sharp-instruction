using System;

namespace Day1Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.Write("abc");
            //Console.WriteLine("xyz");
            //Console.WriteLine("Enter a name: ");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("name = " + str1);
            //Console.WriteLine("Enter a whole number: ");
            //int i1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a whole number: ");
            //int i2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sum = " + (i1 + i2));

            //string choice = "y";
            //while (choice.Equals("y"))
            //{
            //    Console.WriteLine("hey");
            //    choice = Console.ReadLine();

            //}

            //if (i2 > 5)
            //{
            //    Console.WriteLine("i2 is greater thatn 5");
            //}
            //else
            //{
            //    Console.WriteLine("i2 is less thatn or equal to 5");
            //}


            Random rand = new Random();
            int rand1 = rand.Next(10);
            Console.WriteLine("rand1 = " + rand1);

            Console.WriteLine("Generate Random numbers");
            for (int i = 0; i < 1000; i++)
            {
                rand1 = rand.Next(10)+1;
                Console.WriteLine("rand1 = " + rand1);
            }

            double d1 = 12345.6789;
            Console.WriteLine("d1 = " + d1);
            double d2 = Math.Round(d1, 2);
            Console.WriteLine("d2 = " + d2);

            double price = d1;
            Console.WriteLine("formated price: " + price.ToString("C2"));
            double pct = .036789;
            Console.WriteLine("Formated pct: " + pct.ToString("P3"));

            int i3 = 7; 

            switch (i3)
           
            {
                case 1:
                    Console.WriteLine("i3 = 1");
                    break;

                case 2:
                    Console.WriteLine("i3 = 2");
                    break;

                case 3:
                    Console.WriteLine("i3 = 3");
                    break;

                case 4:
                    Console.WriteLine("i3 = 4");
                    break;

                case 5:
                    Console.WriteLine("i3 = 5");
                    break;


                default:
                    Console.WriteLine("not between 1 and 5");
                    break;
            }



            Console.WriteLine("bye");




        }
    }
}
