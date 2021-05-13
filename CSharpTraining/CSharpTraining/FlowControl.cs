using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	class FlowControl
	{
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
