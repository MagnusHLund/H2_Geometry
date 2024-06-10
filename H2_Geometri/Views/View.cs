using System;

namespace H2_Geometri.Views
{
	internal class View
	{
		/// <summary>
		/// This method outputs a custom message, based on the parameter.
		/// Its a dynamic way to output messages, while still being MVC friendly.
		/// </summary>
		/// <param name="message">Custom string message that should be shown in the console</param>
		internal void Output(string message)
		{
			Console.WriteLine(message);
		}
	}
}
