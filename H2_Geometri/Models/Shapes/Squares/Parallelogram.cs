using System;

namespace H2_Geometri.Models.Shapes.Squares
{
	internal class Parallelogram : AbstractSquare
	{
		private float _b;
		private float _v;

		public Parallelogram(float a, float b, float v) : base (a)
		{
			// Validates that the dimensions are all greater than 0. 
			ValidateDimension(a, b, v);

			_a = a;
			_b = b;
			_v = v;
		}

		/// <summary>
		/// Overrides the method to calculate the Perimeter for a parallelogram
		/// </summary>
		/// <returns>Float value of the perimeter</returns>
		public override float CalculatePerimeter()
		{
			return 2*(_a + _b);
		}

		/// <summary>
		/// Overrides the method to calculate the area for an parallelogram
		/// </summary>
		/// <returns>Float value of the area</returns>
		public override float CalculateArea()
		{
			float angleRadians = (float)(_v * Math.PI / 180);
			return (float)(_a * _b * Math.Sin(angleRadians));
		}
	}
}
