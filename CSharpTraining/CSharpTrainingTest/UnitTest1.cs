using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpTrainingTest
{
	/*
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
		}
	}
}
