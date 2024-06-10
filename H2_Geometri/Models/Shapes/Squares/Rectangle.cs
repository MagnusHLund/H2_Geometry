namespace H2_Geometri.Models.Shapes.Squares
{
	internal class Rectangle : AbstractSquare
	{
		private float _b;

		internal Rectangle(float a, float b) : base(a)
		{
			// Validates that the dimensions are all greater than 0. 
			ValidateDimension(a, b);

			_a = a;
			_b = b;
		}

		/// <summary>
		/// Overrides the method to calculate the Perimeter for a rectangle
		/// </summary>
		/// <returns>Float value of the perimeter</returns>
		public override float CalculatePerimeter()
		{
			float sides = _a * 2;
			float length = _b * 2;
			return sides + length;
		}

		/// <summary>
		/// Overrides the method to calculate the area for an rectangle
		/// </summary>
		/// <returns>Float value of the area</returns>
		public override float CalculateArea()
		{
			float side = _a;
			float length = _b;
			return side * length;
		}
	}
}
