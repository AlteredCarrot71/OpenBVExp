namespace Common.Colors
{
	/// <summary>Represents an RGBA color with 8-bit precision per channel.</summary>
	public class RGBA
    {
		public byte R { get; set; }
		public byte G { get; set; }
		public byte B { get; set; }
		public byte A { get; set; }

		public RGBA(byte r, byte g, byte b, byte a)
		{
			R = r;
			G = g;
			B = b;
			A = a;
		}
	}
}