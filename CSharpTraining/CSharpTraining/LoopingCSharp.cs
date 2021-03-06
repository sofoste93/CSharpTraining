using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	public class LoopingCSharp
	{
		// Managing flow with break and continue
		public string BreakAndContinue()
		{
			var sBuilder = new StringBuilder();
			var words = new List<string>() { "Bread", "Eggs", "Milk", "Cheese", "Apples" };
			foreach (var word in words)
			{
				if (word.StartsWith("M")) continue; // ..skip everything underneath it and just go back around the loop one more time

				if (word.StartsWith("C")) break;

				sBuilder.AppendLine(word);
			}
			return sBuilder.ToString();
		}

		// do-while Loop
		public int DoWhileLoop()
		{
			var sum = 0;
			var counter = 0;
			do
			{
				sum += counter;
				counter++;
			} while (counter < 100);

			return sum;
		}

		// while loop
		public int WhileLoop()
		{
			var sum = 0;
			var counter = 0;

			while (counter < 100)
			{
				sum += counter;
				counter++;
			}
			return sum;
		}

		// foreach loop
		public int ForEachLoop()
		{
			var numbers = new List<int> { 1, 3, 5, 7, 9 };
			var sum = 0;

			foreach (var number in numbers)
			{
				sum += number;
			}

			return sum;
		}

		// For loop
		public int ForLoop()
		{
			var sum = 0;
			for (var i = 0; i < 100; i++) // start counting at 0
			{
				sum = sum + i; // sum += i;
				
			}
			return sum;
		}
	}
}
