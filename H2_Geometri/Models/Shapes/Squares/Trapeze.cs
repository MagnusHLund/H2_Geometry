using H2_Geometri.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Geometri.Models.Squares
{
	internal class Trapeze : AbstractSquare
	{
		private int _b;
		private int _c;
		private int _d;
		private int _h;

		internal Trapeze(int a, int b, int c, int d, int h) : base(a)
		{
			_a = a;
			_b = b;
			_c = c;
			_d = d;
			_h = h;
		}

		internal override float CalculatePerimeter()
		{
			int sides = _c;
			int bottom = _b;
			int top = _d;

			return (sides * 2) + bottom + top;
		}

		internal override float CalculateArea()
		{
			int side = _a;
			int bottom = _b;
			int height = _h;

			return 0.5f * (side + bottom) * height;
		}
	}
}
