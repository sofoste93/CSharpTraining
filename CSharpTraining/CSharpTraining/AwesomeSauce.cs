using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	public class AwesomeSauce
	{
		public List<string> Sauces { get; set; }

		// : .constructor
		public AwesomeSauce()
		{
			Sauces = new List<string>();
		}
		// method: boolean return type
		public bool IsSauceAwesome(string sauce)
		{
			return Sauces.Contains(sauce);
		}
	}
}
