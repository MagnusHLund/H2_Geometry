using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2_Geometri.Models.Shapes;

namespace H2_Geometri.Models.shapes.Squares
{
	internal class Parallelogram : AbstractSquare
	{
		private int _b;

		internal Parallelogram(int a, int b) : base (a){
			_a = a;
			_b = b;
		}

		internal override float CalculatePerimeter()
		{
			return 2*(_a + _b);
		}

		internal override float CalculateArea()
		{
			return (float)(_a * _b * Math.Sin(0));
		}
	}
}
