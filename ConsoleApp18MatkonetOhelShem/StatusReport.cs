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

        //question 5b
        public Tree(string location, int code)
        {
            this.location = location;
            this.code = code;
        }
        #region this part is not required
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
        //question 5c.
        public bool SameLocation(Tree other) => location == other.location;


    }
    internal class StatusReport
    {

        private int code;
        private Tree[] arr;
        private int count = 0;// אולי לא הוגדר. בכל מקרה נחוץ
        public StatusReport(int code, Tree[] trees) // if we have a100000 trees
        {
            this.code = code;
            arr = new Tree[1000];

            for (int i = 0; i < trees.Length; i++)
            {
                if (trees[i].GetCode() == code)
                {
                    arr[count] = trees[i];
                    count++;
                }
                if (count == 1000) //avoid index ouf of range.
                    break;
            }
        }
        private static Random rnd= new Random();
        /// <summary>
        /// מגרילה עץ מתוך המלאי הקיים
        /// </summary>
        /// <param name="code"></param>
        public Tree GetTree(int code)
        {
            for (int i = 0; i < 100; i++)
            {
                int ind = rnd.Next(count);
                if (arr[ind].GetCode() == code)
                    return arr[ind];
            }
            return default(Tree); //
        }

        public int GetCode()
        {
            return code;
        }
        public void SetCode(int value)
        {
            code = value;
        }
    }
}
