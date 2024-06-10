using H2_Geometri.Models.Shapes;
using H2_Geometri.Models.Shapes.Squares;
using H2_Geometri.Models.Shapes.Triangles;
using System;
using System.Collections.Generic;

namespace H2_Geometri.Controllers
{
	internal class MainController
	{
		/// <summary>
		/// This is the entry point of the MainController class.
		/// It is also the only method, within the class.
		/// It creates a list containing one of each shape, available in the program.
		/// Then it loops through each of them and calculates the area and perimeter of the shape.
		/// The values are then outputted to the console window, using the view class.
		/// The method also has exception handling, catching an error thrown within the AbstractShape class.
		/// </summary>
		internal void Main()
		{
			Views.View view = new Views.View();
			try
			{
				List<AbstractShape> shapes = new List<AbstractShape>()
				{
					new IsoscelesTrapezoid(10, 8, 9),
					new Parallelogram(3, 5, 20),
					new Rectangle(4, 2),
					new Square(5),
					new RightAngledTriangle(3.5f, 5)
				};

				foreach (AbstractShape shape in shapes)
				{
					string name = shape.GetType().Name;
					float area = shape.CalculateArea();
					float perimeter = shape.CalculatePerimeter();

					view.Output($"Shape: {name} \nArea: {area} \nPerimeter: {perimeter} \n");
				}
			}
			catch (ArgumentException e)
			{
				view.Output($"The code stopped, due to a shape value being 0 or less. {e.Message}");
			}

			Console.ReadLine();
		}
	}
}
