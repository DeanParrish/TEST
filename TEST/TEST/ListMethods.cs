using System;
using System.Collections.Generic;

namespace TEST
{
    public class ListMethods
    {
        public List<int> lstNums = new List<int>();
        public List<int> lstMultiples = new List<int>();
		public int end;
        
		public ListMethods(string endNum)
		{
			int.TryParse(endNum, out end);
		}
        //FILLS SELECTED LIST WITH NUMBER UP TO USER SELECTED END
        public void ConstructList(List<int> list)
        {
			if (end > 0)
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

		public void ConstructFibonacci(List<int> lst)
        {
			int sum;
			if (end > 0)
            {
                for (int i = 1; i <= 2; i++)
                {
					lst.Add(i);
                }

				do {
					sum = lst[lst.Count-2] + lst[lst.Count-1];
					if (sum < end) {
						lst.Add(sum);
					}

					} while (sum < end);
            }
        }
		//DISPLAYES SELECTED <INT>LIST
		public void DisplayList(List<int> lst)
        {
			foreach (var item in lst) {
				Console.WriteLine (item.ToString());
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
