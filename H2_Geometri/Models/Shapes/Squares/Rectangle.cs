using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Geometri.Models.Shapes.Squares
{
	internal class Rectangle : AbstractSquare
	{
		private int _b;

		internal Rectangle(int a, int b) : base(a)
		{
			_a = b;
			_b = b;
		}

		internal override float CalculatePerimeter()
		{
			int sides = _a * 2;
			int length = _b * 2;
			return sides + length;
		}

		internal override float CalculateArea()
		{
			int side = _a;
			int length = _b;
			return side * length;
		}
	}
}
