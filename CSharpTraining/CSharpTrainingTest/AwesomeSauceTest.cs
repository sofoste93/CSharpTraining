using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CSharpTraining;

namespace CSharpTrainingTest
{
	[TestClass]
	public class AwesomeSauceTest
	{
		[TestMethod]
		public void IsSauceAwesomeTest()
		{
			var testInstance = new AwesomeSauce();
			testInstance.Sauces.Add("Tobasco");
			testInstance.Sauces.Add("Cholula");
			testInstance.Sauces.Add("Trailer Trash");

			// true expected
			Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));
			// false expected
			Assert.IsTrue(testInstance.IsSauceAwesome("Ketchup"));

		}
	}
}
