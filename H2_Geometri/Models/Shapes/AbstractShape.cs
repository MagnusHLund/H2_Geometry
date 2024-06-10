using H2_Geometri.Interfaces;

namespace H2_Geometri.Models.Shapes
{
	public abstract class AbstractShape : IShapes
	{
		public abstract float CalculatePerimeter();
		public abstract float CalculateArea();
	}
}
