using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEST
{
    public class ListMethods
    {
        public List<int> lstNums = new List<int>();
        public List<int> lstMultiples = new List<int>();
        
        //FILLS SELECTED LIST WITH NUMBER UP TO USER SELECTED END
        public void ConstructList(List<int> list, string input)
        {
            int end;

            if (int.TryParse(input, out end))
            {
                for (int i = 1; i < end; i++)
                {
                    list.Add(i);

                }
            }
            else
            {
                Console.WriteLine("X");
            }

        }

        public void ConstructFibonacci(List<int> list, string input)
        {
            int end;

            if (int.TryParse(input, out end))
            {
                for (int i = 1; i <= 2; i++)
                {
                    list.Add(i);
                }

                for (int i = 0; i < end; i++)
                {
                    int add = list[list.Count-1] + list[list.Count];
                    list.Add(add);
                }
            }
        }
        //DISPLAYES SELECTED LIST
        private void DisplayList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }

        //ADDS MULTIPLES OF CERTAIN NUMBER FROM ONE LIST TO ANOTHER LIST
        public void AddMultipleToList(List<int> inList, List<int> outList, int multiple)
        {
            foreach (int item in inList)
            {
                if (item % multiple == 0)
                {
                    outList.Add(item);
                }
            }
            outList.Sort();
        }
        
    }
}
