namespace H2_Geometri.Models.Shapes
{
	/// <summary>
	/// This is the super class for the square shapes.
	/// Each square has an _a field, which gets its value when a square is created.
	/// </summary>
	internal abstract class AbstractSquare : AbstractShape
	{
		protected float _a;

		internal AbstractSquare(float a)
		{
			_a = a;
		}
	}
}
