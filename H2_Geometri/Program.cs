using H2_Geometri.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Geometri
{
	internal class Program
	{
		/// <summary>
		/// This method is the starting point of the application. 
		/// It calls the MainController class' Main() method.
		/// </summary>
		static void Main()
		{
			new MainController().Main();
		}
	}
}
