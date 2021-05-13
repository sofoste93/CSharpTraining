using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	/*VS doesn't put an access modifier by default
	 * so make sure to check it
	 */
	public class SimpleArray
	{
		public string[] GroceryList; // create array

		public SimpleArray()
		{
			GroceryList = new string[4] {"Bread", "Milk", "Eggs", "Soda"};
		}

		public override string ToString()
		{
			// return base.ToString();
			return "There are " + GroceryList.Length + " and they are: "
				+ GroceryList.ToString();
		}

	}
}
