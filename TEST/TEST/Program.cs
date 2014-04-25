using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {        
        static void Main(string[] args)
        {
			string strTest = "taiosjr ioahsdi aioshdasoi aoisdjioas the aisoiosa kasdlsand.";
			/*
            Console.WriteLine("Enter length of list");
			FibonacciList test = new FibonacciList (Console.ReadLine().ToString ());
			test.ConstructFibonacci (test.lstNums);
			test.AddMultipleToList (test.lstNums, test.lstMultiples, 2);
			test.DisplayList (test.lstMultiples);
			Console.WriteLine ("");
			test.DisplayList (test.lstNums);
			Console.WriteLine ("");
			Console.WriteLine (test.GetListSum(test.lstMultiples));*/
			//Console.WriteLine(test.end.ToString());
			//test.ConstructFibonacci(test.lstNums, Console.ReadLine());
            //test.ConstructList(test.lstNums, Console.ReadLine());
            //test.AddMultipleToList(test.lstNums, test.lstMultiples, 2);
            //Console.WriteLine(test.lstMultiples.Sum().ToString());

            
            //StringIterator str = new StringIterator (strTest);
            //Console.WriteLine (str.GetWord (str.myString, 15));

            //DTResults dt = new DTResults();
            //dt.GetDateResults(DateTime.Today);

            //float fl = 12.51231234123f;
            //Console.WriteLine(fl);

            //MathProbs mathP = new MathProbs();
            //Console.WriteLine(mathP.GetFactorial(3));
            //Console.Read();

            CurrencyConversion CurrConv = new CurrencyConversion(50.00m);
            Console.WriteLine(CurrConv.ConvertUSDToEUR(CurrConv.deciAmount));
            Console.WriteLine(CurrConv.ConvertPesoToUSD(CurrConv.deciAmount));

            Console.Read();
        }
    }
}
