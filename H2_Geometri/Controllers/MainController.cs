using H2_Geometri.Models.Squares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Geometri.Controllers
{
	internal class MainController
	{
		internal void Main()
		{
			Square square = new Square(10);
			Rectangle rectangle = new Rectangle(1, 2);
			parallelogram parallelogram = new parallelogram(3,4);
			Trapeze trapeze = new Trapeze(5, 6, 7, 8, 9);

			square.CalculateArea();
			rectangle.CalculateArea();
			parallelogram.CalculateArea();
			trapeze.CalculateArea();

			square.CalculatePerimeter();
			rectangle.CalculatePerimeter();
			parallelogram.CalculatePerimeter();
			trapeze.CalculatePerimeter();

			Views.View view = new Views.View();
		}
	}
}
