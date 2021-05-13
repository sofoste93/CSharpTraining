using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	public class LoopingCSharp
	{
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
