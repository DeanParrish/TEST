using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEST
{
    class DTResults
    {
        public DTResults GetDateResults(DateTime date)
        {
            Console.WriteLine("Today's Date:{0}", date.Date.ToString());
            Console.WriteLine("{0}-{1}-{2}",date.Month.ToString(), date.Day.ToString(), date.Year.ToString());
            Console.WriteLine(date.Subtract(TimeSpan.FromDays(1)));
            
            return new DTResults();
        }
    }
}
