using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// remember to use referencies
using CSharpTraining;

namespace CSharpTrainingTest
{
	[TestClass]
	public class SimpleArrayTest
	{
		[TestMethod]
		public void TestInstantiation()
		{
			var testInstance = new SimpleArray();

			Assert.AreEqual(testInstance.GroceryList.Length, 4);
			Assert.AreEqual(testInstance.GroceryList[2], "Eggs");
		}
		[TestMethod] // always do this - otherwise won't recognize
		public void TestToString()
		{
			var testInstance = new SimpleArray();
			Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
		}

	}
}
