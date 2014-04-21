using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEST
{
    class Program
    {        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter length of list");
			ListMethods test = new ListMethods (Console.Read ().ToString ());
			test.ConstructList (test.lstNums);
			test.DisplayList (test.lstNums);
			Console.WriteLine(test.end.ToString());
			//test.ConstructFibonacci(test.lstNums, Console.ReadLine());
            //test.ConstructList(test.lstNums, Console.ReadLine());
            //test.AddMultipleToList(test.lstNums, test.lstMultiples, 2);
            //Console.WriteLine(test.lstMultiples.Sum().ToString());
            
			Console.Read();
        }
    }
}
