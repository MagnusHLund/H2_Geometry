using H2_Geometri.Interfaces;
using H2_Geometri.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Geometri.Models.Squares
{
	internal class Square : AbstractSquare
	{
		private protected int _sides;

		internal int Sides 
		{ 
			get { return _sides; } 
			set { _sides = value; } 
		}

		internal Square(int sideLength)
		{
			_sides = sideLength;
		}

		internal virtual float CalculatePerimeter()
		{
			return _sides * 4;
		}

		internal virtual float CalculateArea()
		{
			return _sides * _sides;
		}
	}
}
