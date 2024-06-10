using System;

namespace H2_Geometri.Models.Shapes.Squares
{
	internal class IsoscelesTrapezoid : AbstractSquare
	{
		private float _b;
		private float _c;

		internal IsoscelesTrapezoid(float a, float b, float c) : base(a)
		{
			// Validates that the dimensions are all greater than 0. 
			ValidateDimension(a, b, c);

			_a = a;
			_b = b;
			_c = c;
		}

		/// <summary>
		/// Overrides the method to calculate the Perimeter for an isosceles
		/// </summary>
		/// <returns>Float value of the perimeter</returns>
		public override float CalculatePerimeter()
		{
			return 2 * _c + _a + _b;
		}

		/// <summary>
		/// Overrides the method to calculate the area for an isosceles
		/// </summary>
		/// <returns>Float value of the area</returns>
		public override float CalculateArea()
		{
			float h = CalculateHeight();

			return 0.5f * (_a + _b) * h;
		}

		/// <summary>
		/// Calculates the height of the isoceles shape
		/// </summary>
		/// <returns>Float value of the height</returns>
		private float CalculateHeight()
		{
			float halfDifference = (_b - _a) / 2;
			return (float)Math.Sqrt(_c * _c - halfDifference * halfDifference);
		}
	}
}
