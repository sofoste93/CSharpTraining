using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingApp
{
	class Program
	{
		// add a list type to the class
		public static List<string> Words;
		static void Main(string[] args)
		{
			Words.Add("Bread"); // make List<> static to use this
			Words.Add("Milk");
			Words.Add("Cheese");
			Words.Add("Soda");
		}
	}
}
