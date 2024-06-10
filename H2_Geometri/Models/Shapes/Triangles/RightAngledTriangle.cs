using System;

namespace H2_Geometri.Models.Shapes.Triangles
{
	internal class RightAngledTriangle : AbstractTriangle
	{
		private float _b; 

		internal RightAngledTriangle(float a, float b) : base (a) 
		{
			// Validates that the dimensions are all greater than 0. 
			ValidateDimension(a, b);

			_a = a; 
			_b = b;
		}

		/// <summary>
		/// Overrides the method to calculate the Perimeter for a right angled triangle
		/// </summary>
		/// <returns>Float value of the perimeter</returns>
		public override float CalculatePerimeter()
		{
			float c = CalculateUnknownSide();
			return _a + _b + c;
		}

		/// <summary>
		/// Overrides the method to calculate the area for an right angled triangle
		/// </summary>
		/// <returns>Float value of the area</returns>
		public override float CalculateArea()
		{
			return (0.5f * _a * _b);
		}

		/// <summary>
		/// Calculates the missing value, which one of the triangle sides has, using pythagoras
		/// </summary>
		/// <returns>Float value of the unkown side value</returns>
		internal float CalculateUnknownSide()
		{
			float aSquared = _a * _a;
			float bSquared = _b * _b;

			float cSquared = aSquared + bSquared;

			return (float)Math.Sqrt(cSquared);
		}
	}
}
