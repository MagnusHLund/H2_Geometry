namespace H2_Geometri.Interfaces
{
	/// <summary>
	/// This interface has 2 methods, which return a float.
	/// I decided to use float rather than double, because i dont think i can justify the extra RAM usage, for these calculations.
	/// </summary>
	internal interface IShapes
	{
		float CalculatePerimeter();
		float CalculateArea();
	}
}
