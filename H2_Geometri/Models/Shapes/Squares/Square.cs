namespace H2_Geometri.Models.Shapes.Squares
{
	internal class Square : AbstractSquare
	{
		internal Square(float a) : base(a)
		{
			// Validates that the dimension is greater than 0
			ValidateDimension(a);

			_a = a;
		}

		/// <summary>
		/// Overrides the method to calculate the Perimeter for a square
		/// </summary>
		/// <returns>Float value of the perimeter</returns>
		public override float CalculatePerimeter()
		{
			return _a * 4;
		}

		/// <summary>
		/// Overrides the method to calculate the area for an rectangle
		/// </summary>
		/// <returns>Float value of the area</returns>
		public override float CalculateArea()
		{
			return _a * _a;
		}
	}
}
