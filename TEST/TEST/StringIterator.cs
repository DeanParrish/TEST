using System;

namespace TEST
{
	public class StringIterator
	{
		public string myString {
			get;
			set;
		}


		public StringIterator (string str)
		{
			myString = str;
		}

		public string GetWord(string str, int wordNum)
		{
			int intSpaceCount = 0;
			int intCharCount = 0;
			int intStringLength = 0;
			string strRet = "";

			foreach (char letter in str) {
                if ((intSpaceCount + 1) == wordNum)
                {
                    intSpaceCount = str.IndexOf(" ", intCharCount + 1);
                    intStringLength = intSpaceCount - intCharCount;
                    strRet = str.Substring((intSpaceCount - intStringLength), intStringLength);
                    break;
                }

				if (letter != ' ') {
					intCharCount++;
				}
				else if (letter == ' ') {
					intCharCount++;
					intSpaceCount++;
				}

                if (wordNum > intSpaceCount)
                {
                    return "End of String.";
                }
				
			}            
			return strRet;
		}
	}
}

