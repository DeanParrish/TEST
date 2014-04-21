using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        private void GetMessage(int end)
        {
            for (int i = 0; i < end; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
                //try
                //{
                //    //Console.WriteLine("Please enter ending number: ");

                //    //end = int.Parse(Console.ReadLine());

                //    for (int i = 1; i <= end; i++)
                //    {
                //        string message = i.ToString() + ". ";

                //            if (i % 3 == 0)
                //            {
                //                message += "Fizz";
                //            }
                //            if (i % 5 == 0)
                //            {
                //                message += "Buzz";
                //            }

                //            Console.WriteLine(message);
                        

                //    }
                //}
                //catch (Exception e)
                //{

                //    Console.WriteLine("Please enter a valid number. " + e.GetType());
                //}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ending number:");
            int end = int.Parse(Console.ReadLine());

            Program x = new Program();
            x.GetMessage(end);        
            Console.Read();

        }
    }
}
