using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// in order to read text in file
using System.IO;

// use NLog
using NLog;

namespace CSharpTrainingApp
{
	/**
	 * EXCEPTION HANDLING
	 * 
	 * - Runtime exception: 
	 *	it occurs, when you've got a mistake in your code,
	 *  a problem with your code. And it's not going
	 *  to be caught by the compiler.
	 * 
	 * - Debugging exception in code
	 *  you might use brakePoints to inspect your code
	 * 
	 * - Handling exceptions with try-catch block
	 * 
	 * - Using multiple catch statements
	 * 
	 * - Cleaning up with finally
	*/
	class Program
	{
		// add logging
		public static Logger logger = LogManager.GetCurrentClassLogger();

		// add a list type to the class
		public static List<string> Words;
		static void Main(string[] args)
		{
			// logger
			logger.Trace("The program started");

			// initialize var first
			Words = new List<string>();

			Words.Add("Bread"); // make List<> static to use this
			Words.Add("Milk");
			Words.Add("Cheese");
			Words.Add("Soda");

			// call methods
			ReadTextFile();
			Console.ReadLine();
			CrazyMathProblem();

		}

		private static void ReadTextFile()
		{
			try
			{
				using (var sReader = new StreamReader(@"C:\temp\test.txt")) // A:\\temp\\test.txt
				{
					string contents = sReader.ReadToEnd();
					Console.WriteLine(contents);
				}
			}
			catch (System.IO.DirectoryNotFoundException dExc)
			{
				Console.WriteLine("Couldn't find the directory.");
				logger.Error("The directory was not found." + dExc.Message);
			}
			catch(System.IO.FileNotFoundException fExc)
			{
				Console.WriteLine("Couldn't find the file.");
				logger.Error(fExc.Message);
			}
			catch(Exception exc)
			{
				Console.WriteLine("An unknown error occured " + exc.Message);
			}
			finally
			{
				Console.WriteLine("\nAm the 'finally-block'. I always run.");
			}

		}

		private static int CrazyMathProblem() 
		{
			var income = 1500;
			for (var i = 0; i >0 ; i--) // we know it's going to fail
			{
				income = income = (income / i);
			}
			return income;
		}
	}
}
