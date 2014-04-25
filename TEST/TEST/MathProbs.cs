using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEST
{
    class MathProbs
    {
        public int GetFactorial(int i)
        {
            try
            {
                if (i<=1)
                {
                    return 1;  
                }
                return i * GetFactorial(i - 1);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;

            }
        }
    }
}
