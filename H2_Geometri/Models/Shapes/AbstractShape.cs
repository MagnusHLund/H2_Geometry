using H2_Geometri.Interfaces;
using System;

namespace H2_Geometri.Models.Shapes
{
	/// <summary>
	/// A class which all shapes inherit from. 
	/// It does not contain any fields. Both triangles and squares use the _a variable, however if i did circle calculations, i would use r or D.
	/// This is why i did not create the _a field within this class.
	/// </summary>
	public abstract class AbstractShape : IShapes
	{
		/// <summary>
		/// Ensures that all the values within a float array, is greater than 0.
		/// If any value is not above 0, then an error is thrown.
		/// </summary>
		/// <param name="dimensions"></param>
		/// <exception cref="ArgumentException"></exception>
		protected void ValidateDimension(params float[] dimensions)
		{
			foreach (float dimension in dimensions)
			{
				if (dimension <= 0)
				{
					throw new ArgumentException("Dimension must be more than 0.");
				}
			}
		}

		public abstract float CalculatePerimeter();
		public abstract float CalculateArea();
	}
}
