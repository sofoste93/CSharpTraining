using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	class FlowControl
	{
		// Logical NOT
		public string IsYourNameNotBruce(string yourName)
		{
			if(yourName.ToLower() != "bruce")
			{
				return "Can we call you Bruce for the sake of simplicity?";
			} else
			{
				return "G'day Bruce!";
			}
		}

		// Compound logic with logical AND
		public string GradeLetter(int score)
		{
			if(score > 90)
			{
				return "A";
			} else if(score > 79 && score < 90)
			{
				return "B";
			} else if(score >= 70 && score <= 80)
			{
				return "C";
			} else
			{
				return "F";
			}

		}

		// Compound logic with logical OR
		public string PrimOrSecondCompound(string color)
		{
			if ((color.ToLower() == "red") || (color.ToLower() == "blue") || (color.ToLower() == "yello"))
			{
				return "Primary";
			} else
			{
				return "Secondary";

			}

		}

		// switch-statement
		public string SecondOrPrimSwitch(string color)
		{
			var result = "";

			switch (color.ToLower())
			{
				case "red":
					result = "Primary";
					// could have more statements here
					break;
				case "blue":
					result = "Primary";
					// could have more statements here
					break;
				case "yellow":
					result = "Primary";
					// could have more statements here
					break;

				default:
					result = "Secondary";
					break;
			}
			return result;
	
		}

		// if-else-statement
		public string PrimaryOrSecondary(string color)
		{
			var result = "";

			if (color.ToLower() == "red")
			{
				result = "Primary";
			}
			else if (color.ToLower() == "blue")
			{
				result = "Primary";
			} else if(color.ToLower() == "yellow")
			{
				result = "Primary";
			} else
			{
				result = "Secondary";
			}

			return result;
		}

		public bool IsYourFavoriteColorYellow(string color)
		{
			return(color.ToLower() == "yellow");
		}

		public bool IsYourFavoriteColorRed(string color)
		{
			if (color.ToLower() == "red") return true;
			return false;
		}
		public bool IsYourFavoriteColorGreen(string color)
		{
			return (color.ToLower() == "green") ? true : false;
		}

		public bool IsYourFavoriteColorBlue(string color)
		{
			if(color.ToLower() == "blue")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
