namespace H2_Geometri.Models.Shapes
{
	public abstract class AbstractSquare : AbstractShape
	{
		private protected float _left;
		private protected float _right;
		private protected float _top;
		private protected float _bottom;

		public AbstractSquare(float left, float right, float top, float bottom)
		{
			_left = left;
			_right = right;
			_top = top;
			_bottom = bottom;
		}
	}
}
