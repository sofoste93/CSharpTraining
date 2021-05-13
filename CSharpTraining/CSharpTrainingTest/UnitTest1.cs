using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

// remember to use required rederencies
using CSharpTraining;

namespace CSharpTrainingTest
{
	/*
	 * Remember:
	 * Now there's one last step that we need to perform 
	 * in order for this to be a working testing project.
	 * We need to aasociate these two project together so
	 * that the test can actually see the classes in our
	 * class library. To do this we need to add a reference
	 * 
	 */
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var testInstance = new Class1();
			var testResult = testInstance.AddTwo(9, 7);

			Assert.AreEqual(16, testResult, "We expect (9 + 7) to be 16");
		}
	}
}
