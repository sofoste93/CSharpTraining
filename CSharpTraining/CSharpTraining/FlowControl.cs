using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	class FlowControl
	{
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
