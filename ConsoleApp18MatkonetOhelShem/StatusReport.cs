using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18MatkonetOhelShem
{
    internal class Tree
    {

		private int code;

		private string location;

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
    }
    internal class StatusReport
    {
    }
}
