using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18MatkonetOhelShem
{
    internal class Tree
    {

        //question 5a
        private int code;

		private string location;
		//סעיף ב
        public Tree(int code, string location)
        {
            this.code = code;
			this.location = location;
        }
		public bool SameLocation(Tree other)
		{
			if (other.location == this.location)
				return true;
			return false;
		}
        public bool SameLocation1(Tree other)
        {
			return other.location == this.location;
        }
        public bool SameLocation2(Tree other) => other.location == this.location;
        
        #region not needed
        public string GetLocation()
		{
			return location;
		}
		public void SetLocation(string value)
		{
			location = value;
		}
		public int GetCode()
		{
			return code;
		}
		public void SetCode(int value)
		{
			code = value;
		}
        #endregion
    }
    internal class StatusReport
    {
		//private Tree[] arr = new Tree[1000];
		private int st;
		private Tree[] arr;
		private int count;

		// סעיף ה
        public StatusReport(Tree[] trees, int st)
        {
			arr = new Tree[1000];
			count = 0;
			this.st = st;

			for (int i = 0; i < trees.Length; i++)
			{
				if (trees[i].GetCode() == st)
				{
                    if (count == 1000)
                    {   // exceeding index 999
                        Console.WriteLine("too many trees");
						break;
                    }
                    arr[count] = trees[i];
					count++; // מייצג את המקום הפנוי הבא
					
				}
			}
        }

        public int GetCount()
		{
			return count;
		}
		public void SetCount(int value)
		{
			count = value;
		}

		public int GetSt()
		{
			return st;
		}
		public void SetSt(int value)
		{
			st = value;
		}

    }
}
