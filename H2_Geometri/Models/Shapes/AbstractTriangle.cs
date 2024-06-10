namespace H2_Geometri.Models.Shapes
{
	/// <summary>
	/// This is the super class for the triangle shapes.
	/// Each triangle has an _a field, which gets its value when a triangle is created.
	/// </summary>
	public abstract class AbstractTriangle : AbstractShape
	{
		protected float _a;

		internal AbstractTriangle(float a)
		{
			_a = a;
		}
	}
}
