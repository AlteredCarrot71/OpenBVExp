namespace Common.Colors
{
	/// <summary>Represents an RGB color with 8-bit precision per channel.</summary>
	public class RGB
	{
		public byte R { get; set; }
		public byte G { get; set; }
		public byte B { get; set; }

		public RGB(byte r, byte g, byte b)
		{
			R = r;
			G = g;
			B = b;
		}
	}
}